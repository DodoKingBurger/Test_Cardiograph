using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;
using Test_Cardiograph.Services.Controller.MECG.structs;
using System.Linq.Expressions;
using Test_Cardiograph.Services.Controller.MECG.dllController;
using System.Windows.Input;
using System.Reflection.PortableExecutable;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Test_Cardiograph.Controller
{
  /// <summary>
  /// Многоканальная тест-система ЭКГ.
  /// </summary>
  public class MECG : DllController, INotifyPropertyChanged
  {
    #region Поля и свойства 

    /// <summary>
    /// Статус подключения.
    /// </summary>
    public bool ConnectionStatus { get; set; } = false;

    private ECG_HEADER header;

    /// <summary>
    /// ЭКГ заголовок.
    /// </summary>
    public ECG_HEADER Header
    {
      get { return header; }
      set
      {
        header = value;
        OnPropertyChanged("Header");
      }
    }

    #endregion

    #region Методы    

    /// <summary>
    /// Загружает тестовый файл в свойство внутри класса.
    /// </summary>
    /// <param name="file_path">Путь к файлу.</param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="FileNotFoundException"></exception>
    public void Save_header(string file_path)
    {
      if (File.Exists(file_path))
      {
        var header = MECGLoadMITHeader(file_path);
        if (IntPtr.Zero != header)
          this.Header = new ECG_HEADER(Marshal.PtrToStructure<ECG_HEADER_output>(header));//
        else
          throw new ArgumentNullException("ECG_HEADER = IntPtr.Zero");
      }
      else
        throw new FileNotFoundException("File not found");
    }

    /// <summary>
    /// Остановить вывод устройств.
    /// </summary>
    public void Stop_output()
    {
      if (this.ConnectionStatus)
        MECGStopOutput();
      else
        throw new IOException("Устройство не подключено");
    }

    #region Событие по изменению свойства.

    public event PropertyChangedEventHandler? PropertyChanged;
    
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }

    #endregion

    #region Методы подключения и отключения

    /// <summary>
    /// Подключение к MECG.
    /// </summary>
    public string Connected()
    {
      if (MECGConnect(-1, 5000))
      {
        ConnectionStatus = true;
        return $"device is connected ... {MECGGetSerialNumber()}";
        //
      }
      else
      {
        ConnectionStatus = false;
        MECGFree();
        throw new IOException("'Error: device is not connected'");
      }
    }

    /// <summary>
    /// Подключение к MECG.
    /// </summary>
    /// <param name="portNumber">Номер порта.</param>
    /// <returns>Сериальный номер прибора.</returns>
    /// <exception cref="IOException">'Error: device is not connected'</exception>
    public string Connected(int portNumber)
    {
      if (MECGConnect(portNumber, 5000))
      {
        ConnectionStatus = true;
        return $"device is connected ... {MECGGetSerialNumber()}";
        //
      }
      else
      {
        ConnectionStatus = false;
        MECGFree();
        throw new IOException("'Error: device is not connected'");
      }
    }

    /// <summary>
    /// Подключение к MECG.
    /// </summary>
    /// <param name="portNumber">Номер порта.</param>
    /// <param name="millisecondsTimeout">Интервал ожидания.</param>
    /// <returns></returns>
    /// <exception cref="IOException">'Error: device is not connected'</exception>
    public string Connected(int portNumber, int millisecondsTimeout)
    {
      if (MECGConnect(portNumber, millisecondsTimeout))
      {
        ConnectionStatus = true;
        return $"device is connected ... {MECGGetSerialNumber()}";
        //
      }
      else
      {
        ConnectionStatus = false;
        MECGFree();
        throw new IOException("'Error: device is not connected'");
      }
    }

    /// <summary>
    /// Отключение к Serial Port.
    /// </summary>
    public void Disconnected()
    {
      ConnectionStatus = false;
      MECGFree();
    }

    #endregion

    #region Методы Waveform

    /// <summary>
    /// Загрузить периодическую форму сигнала
    /// Непрерывно выводить форму сигнала, пока не будет вызван MECGStopOutput.
    /// </summary>
    /// <param name="waveform"></param>
    /// <param name="frequency">Частота Единица измерения: Гц. Разрешение: 0,01 Гц. Диапазон: 0~100 Гц.</param>
    /// <param name="amplitude">амплитуда Амплитуда напряжение. Единица измерения: мВpp.
    ///</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    public void load_waveform(Enum_WAVEFORM_TYPE _TYPE, double freaquency, double amplitude)
    {
      if (freaquency < 250)
      {
        if (!MECGLoadWaveform(_TYPE, freaquency, amplitude))
          throw new Exception("Отправки команды с периодическую форму сигнала");
        MECGEnableLoop(true);
      }
      else
        throw new ArgumentException("частота слишком велика");
    }

    /// <summary>
    /// Загрузить периодическую форму сигнала
    /// Непрерывно выводить форму сигнала, пока не будет вызван MECGStopOutput.
    /// </summary>
    /// <param name="waveform"></param>
    /// <param name="frequency">частота Частота. Единица: Гц. Разрешение: 0,01 Гц. Диапазон: 0~100 Гц.</param>
    /// <param name="amplitude">амплитуда Амплитуда напряжение. Единица: мВpp. 8 записей расположены в порядке LeadI, LeadII, V1~V6.</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    public void load_waveform(Enum_WAVEFORM_TYPE _TYPE, double freaquency, double[] amplitude)
    {
      if (freaquency < 250)
      {
        if (!MECGLoadWaveformEx(_TYPE, freaquency, amplitude))
          throw new Exception("Отправки команды с периодическую форму сигнала");
        MECGEnableLoop(true);
      }
      else
        throw new ArgumentException("частота слишком велика");
    }

    #endregion

    #region Методы загрузки header файлов

    /// <summary>
    /// Загрузить базу данных Physionet 
    /// Загрузить связанный файл *.dat. Перед вызовом функции необходимо, чтобы все файлы *.dat
    /// были загружены и помещены в ту же папку, что и файл *.hea.
    /// </summary>
    /// <param name="filePath">путь для заголовочного файла.</param>
    /// <exception cref="Exception">"Ошибка загрузки заголовочного файла."</exception>
    public void Load_mit_database(string file_path)
    {
      if (string.Empty != file_path)
      {
        SendHeadearFileMECG(MECGLoadMITHeader(file_path));
        MECGEnableLoop(true);
      }
      else
        throw new ArgumentNullException($"Путь файла пустой.");
    } 

    /// <summary>
    /// Загрузить базу данных Physionet 
    /// Загрузить связанный файл *.dat. Перед вызовом функции необходимо, чтобы все файлы *.dat
    /// были загружены и помещены в ту же папку, что и файл *.hea.
    /// </summary>
    /// <exception cref="Exception">"Ошибка загрузки заголовочного файла."</exception>
    public void Load_mit_database()
    {
      if (this.Header != null)
      {
        SendHeadearFileMECG(this.Header);
        MECGEnableLoop(true);
      }
      else
        throw new ArgumentNullException("Сохраненный заголовочный файл пуст.");
    }

    /// <summary>
    /// Загрузить базу данных Physionet 
    /// В течении 10 секунд подает сигнал из базы данных.
    /// </summary>
    /// <param name="database"></param>
    /// <param name="noise"></param>
    public void LoadDatabaseCTS_CSE(Enum_CTSCSE_Database database, Enum_CTSCSE_Noise noise)
    {
      var header = MECGLoadDatabaseCTS_CSE(database, noise);
      if (IntPtr.Zero != header)
      {
        MECGEnableLoop(true);
        //if (!MECGLoadMITDatabase(new ECG_HEADER(Marshal.PtrToStructure<ECG_HEADER_output>(header))))
        //  throw new Exception("Ошибка загрузки заголовочного файла.");
      }
      else
        throw new Exception("Ошибка, заголовочный файл равен null");
    }

    #endregion

    #region Методы отправки headear файлов

    /// <summary>
    /// Передает MECG команду для эмитации сигнала.
    /// </summary>
    /// <param name="_HEADER">Заголовочный файл, команда, вид сигнала.</param>
    /// <exception cref="Exception">'Ошибка с файлами.'</exception>
    public void SendHeadearFileMECG(IntPtr _HEADER)
    {
      if (IntPtr.Zero != _HEADER)
      {
        if (!MECGLoadMITDatabase(new ECG_HEADER(Marshal.PtrToStructure<ECG_HEADER_output>(_HEADER))))
          throw new Exception("Ошибка загрузки заголовочного файла.");
      }
      else
        throw new Exception("Ошибка, заголовочный файл равен null");
    }

    /// <summary>
    /// Передает MECG команду для эмитации сигнала.
    /// </summary>
    /// <param name="_HEADER">Заголовочный файл, команда, вид сигнала.</param>
    /// <exception cref="Exception">'Ошибка с файлами.'</exception>
    public void SendHeadearFileMECG(ECG_HEADER _HEADER)
    {
      if (!_HEADER.Equals(null))
      {
        if (!MECGLoadMITDatabase(_HEADER))
          throw new Exception("Ошибка загрузки заголовочного файла.");
      }
      else
        throw new Exception("Ошибка, заголовочный файл равен null");
    }

    #endregion

    #region Методы для уведомление о начале вывода

    /// <summary>
    /// Уведомить устройство о начале вывода
    /// </summary>
    /// <param name="startPosition">Начальная позиция для воспроизведения. Единица: секунда</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    public bool Output_waveform(int startPosition)
    {
      if (startPosition >= 0)
        return MECGOutputWaveform(startPosition);
      else
        throw new ArgumentException("Стартовая позиция должна быть больше или равна 0");
    }

    /// <summary>
    /// Уведомить устройство о начале вывода
    /// </summary>
    /// <param name="startPosition">Начальная позиция для воспроизведения. Единица: секунда</param>
    /// <param name="outputSignalCB">Функция обратного вызова, которая возвращает сигналы ЭКГ по 12 отведениям</param>
    /// <param name="outputDelayCB">Функция обратного вызова, которая возвращает время задержки, если произошла задержка передачи пакета</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    public bool Output_waveform(int startPosition, FPtrOutputSignalExCallback outputSignalCB = null)
    {
      if (startPosition >= 0)
        return MECGOutputWaveform(startPosition, outputSignalCB);
      else
        throw new ArgumentException("Стартовая позиция должна быть больше или равна 0");
    }
    /// <summary>
    /// Уведомить устройство о начале вывода
    /// </summary>
    /// <param name="startPosition">Начальная позиция для воспроизведения. Единица: секунда</param>
    /// <param name="outputSignalCB">Функция обратного вызова, которая возвращает сигналы ЭКГ по 12 отведениям</param>
    /// <param name="outputDelayCB">Функция обратного вызова, которая возвращает время задержки, если произошла задержка передачи пакета</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    public bool Output_waveform(int startPosition, FPtrOutputSignalExCallback outputSignalCB = null, FPtrOutputDelayCallback outputDelayCB = null)
    {
      if (startPosition >= 0)
        return MECGOutputWaveform(startPosition, outputSignalCB, outputDelayCB);
      else
        throw new ArgumentException("Стартовая позиция должна быть больше или равна 0");
    }

    #endregion

    #region Метод освобождения ресурсов

    /// <summary>
    /// Освобождение ресурса
    /// Ответственность за освобождение ресурса ECG_HEADER* 
    /// лежит на вызывающем объекте.
    /// </summary>
    public void Free_ecg_header()
    {
      if (!this.Header.Equals(null))
        MECGFreeECGHeader(this.Header);
      else
        throw new ArgumentNullException("Заголовочный файл равен null");
    }

    /// <summary>
    /// Освобождение ресурса
    /// Ответственность за освобождение ресурса ECG_HEADER* 
    /// лежит на вызывающем объекте.
    /// </summary>
    /// <param name="header">заголовок A ::ECG_HEADER указатель</param>
    public void Free_ecg_header(ECG_HEADER _HEADER)
    {
      if (!_HEADER.Equals(null))
        MECGFreeECGHeader(_HEADER);
      else
        throw new ArgumentNullException("Заголовочный файл равен null");
    }

    #endregion

    #endregion

    #region Конструкторы

    static MECG()
    {

    }

    #endregion
  }
}
