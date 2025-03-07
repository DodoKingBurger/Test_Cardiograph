using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Test_Cardiograph.Services.Controller.MECG.structs;

namespace Test_Cardiograph.Services.Controller.MECG.dllController
{
  public abstract class DllController
  {
    #region Поля и свойства

    ///// <summary>
    ///// Путь к файлу с нативной библеотекой.
    ///// </summary>
    //private const string DllFilePath = "MECG20x86.dll";

    ///// <summary>
    ///// Путь к файлу с нативной библеотекой.
    ///// </summary>
    protected const string DllFilePath = "MECG20x64.dll";

    /// <summary>
    /// Делегат для функция вызывается при подключении или отключении устройства.
    /// </summary>
    /// <param name="connected"></param>
    /// <returns>true, если подключено; в противном случае false</returns>
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool FPtrConnectedCallback(bool connected);

    /// <summary>
    /// Called back with sampling data
    /// </summary>
    /// <param name="time">Current position. Unit: second</param>
    /// <param name="voltage">ECG 12-lead signal voltage. Unit: mV</param>
    /// <param name="end"></param>
    public delegate void FPtrOutputSignalCallback(
      double time,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 12)] double[] voltage,
      bool end);

    /// <summary>
    /// Called back with sampling data
    /// </summary>
    /// <param name="totalTime">Total play time. Unit: second</param>
    /// <param name="time">Current position. Unit: second</param>
    /// <param name="voltage">ECG 12-lead signal voltage. Unit: mV</param>
    /// <param name="end"></param>
    public delegate void FPtrOutputSignalExCallback(
      double totalTime,
      double time,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 12)] double[] voltage,
      bool end);

    /// <summary>
    /// Called back with the delay time; 
    /// the delay is detected by the device during outputting signals
    /// </summary>
    /// <param name="time"> time         Unit: ms</param>
    public delegate void FPtrOutputDelayCallback(int time);

    #endregion

    #region Методы импортированные из dll

    #region Функции для обратного вызова 

    /// <summary>
    /// Вызывается при подключении или отключении устройства
    /// </summary>
    /// <param name="connected">true, если подключено; в противном случае false</param>
    [DllImport("MECG20x64.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern void ConnectedCallback(bool connected);

    /// <summary>
    /// Выходной сигнал обратного вызова
    /// Вызов обратного вызова с данными выборки
    /// </summary>
    /// <param name="time">Current position. Unit: second</param>
    /// <param name="voltage">ECG 12-lead signal voltage. Unit: mV</param>
    /// <param name="end"></param>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern void OutputSignalCallback(
      double time,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 12)] double[] voltage,
      bool end);

    /// <summary>
    /// Выходной сигнал обратного вызова
    /// Вызов обратного вызова с данными выборки
    /// </summary>
    /// <param name="totalTime">Total play time. Unit: second</param>
    /// <param name="time">Current position. Unit: second</param>
    /// <param name="voltage">ECG 12-lead signal voltage. Unit: mV</param>
    /// <param name="end"></param>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern void OutputSignalCallback(
      double totalTime,
      double time,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 12)] double[] voltage,
      bool end);

    /// <summary>
    /// Вызывается обратно с задержкой времени;
    /// задержка обнаруживается устройством во время вывода сигналов
    /// </summary>
    /// <param name="time"> time         Unit: ms</param>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern void OutputDelayCallback(int time);

    #endregion

    /// <summary>
    /// Initialization
    /// Во время инициализации он попытается подключить устройство. 
    /// Если устройство найдено,будет вызвана функция cb. 
    /// После этого, если устройство отключено, cb будет вызвана снова, 
    /// чтобы уведомить о событии отключения.
    /// </summary>
    /// <param name="cb">ConnectedCallback - функция вызывается при подключении или отключении устройства</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGInit(FPtrConnectedCallback cb);

    /// <summary>
    /// Подключите устройство.
    /// </summary>
    /// <param name="portNumber">Номер COM-порта устройства.-1 означает, что номер порта выбирается автоматически</param>
    /// <param name="millisecondsTimeout">Время ожидания подключения; количество миллисекунд для подключения или -1 для ожидания на неопределенный срок.</param>
    /// <returns>true, если устройство подключено; false, если истек интервал ожидания иустройство все еще не подключено.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGConnect(
      int portNumber, 
      int millisecondsTimeout);

    /// <summary>
    /// Отключите устройство и очистите библиотечный ресурс.
    /// </summary>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern void MECGFree();

    /// <summary>
    /// Get device serial number
    /// </summary>
    /// <returns>текст серийного номера; НЕ освобождайте возвращаемую строку.</returns>
    [DllImport(DllFilePath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    protected static extern byte MECGGetSerialNumber();

    /// <summary>
    /// Получить информацию о режиме устройства
    /// </summary>
    /// <param name="modelInfo">Указатель на структуру ::MODEL_INFORMATION</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGGetDeviceInformation(
      [param: MarshalAs(UnmanagedType.U4)] MODEL_INFORMATION modelInfo);

    /// <summary>
    /// Проверьте, выводит ли устройство MECG данные.
    /// </summary>
    /// <returns>True, если устройство выводит данные. False в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGIsOutputting();


    /// Загрузить заголовочный файл Physionet

    /// <summary>
    /// Загрузить заголовочный файл Physionet
    /// Вызывающая сторона несет ответственность за освобождение ресурса ECG_HEADER* путем вызова ::MECGFreeECGHeader ().
    /// </summary>
    /// <param name="filePath">Путь к файлу *.hea. Строка с нулевым символом в конце.</param>
    /// <returns>Указатель ::ECG_HEADER, если метод был успешным. NULL в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern IntPtr MECGLoadMITHeader(string filePath);


    /// \brief Загрузить базу данных Physionet 
    /// <summary>
    /// Загрузить связанный файл *.dat. Перед вызовом функции необходимо, чтобы все файлы *.dat
    /// были загружены и помещены в ту же папку, что и файл *.hea.
    /// </summary>
    /// <param name="header">заголовок A ::ECG_HEADER указатель, который возвращается из ::MECGLoadMITHeader ()</param>
    /// <returns>True, если метод был успешным, False в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Auto)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGLoadMITDatabase(ECG_HEADER header);

    /// <summary>
    /// Изменить отображение Lead сигналов
    /// Вызывающий может изменить MappingLead 
    /// структуры ::ECG_SIGNAL, а затем вызвать эту функцию для обновления.
    /// </summary>
    /// <param name="header">заголовок A ::ECG_HEADER указатель</param>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern void MECGUpdateECGHeaderMappingLead(ECG_HEADER header);

    /// <summary>
    /// Освобождение ресурса
    /// Ответственность за освобождение ресурса ECG_HEADER* 
    /// лежит на вызывающем объекте.
    /// </summary>
    /// <param name="header">заголовок A ::ECG_HEADER указатель</param>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern void MECGFreeECGHeader(ECG_HEADER header);

    /// <summary>
    /// Загрузка базы данных AHA в формате *.txt или *.ecg. 
    /// Вызывающая сторона несет ответственность за освобождение ресурса
    /// ECG_HEADER* путем вызова ::MECGFreeECGHeader ().
    /// </summary>
    /// <param name="filePath">filePath Путь к файлу *.txt или *.ecg. Строка с нулевым символом в конце.</param>
    /// <returns>Указатель ::ECG_HEADER, если метод был успешным. NULL в противном случае</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern IntPtr MECGLoadDatabaseAHA(string filePath);

    /// <summary>
    /// Загрузка файла базы данных CSE формата *.dcd. 
    /// Вызывающая сторона несет ответственность 
    /// за освобождение ресурса
    /// ECG_HEADER* путем вызова ::MECGFreeECGHeader ().
    /// </summary>
    /// <param name="filePath">Путь к файлу *.dcd. Строка с нулевым завершением.</param>
    /// <returns>Указатель ::ECG_HEADER, если метод был успешным. NULL в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern IntPtr MECGLoadDatabaseCSE(string filePath);

    /// <summary>
    /// Загрузка файла базы данных в формате txt, 
    /// определенном WhaleTeq. 
    /// Вызывающая сторона несет ответственность 
    /// за освобождение ресурса
    /// </summary>
    /// <param name="filePath">Путь к файлу *.txt.</param>
    /// <returns>ECG_HEADER* путем вызова ::MECGFreeECGHeader (). Частота дискретизации, определенная в файле
    ///, должна находиться в диапазоне от 100 (Гц) до 1000 (Гц).</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern IntPtr MECGLoadDatabaseWhaleTeq(string filePath);

    /// <summary>
    /// Базы данных CTS/CSE встроены в SDK. Вызывающий может загрузить одну,
    /// указав ::CTSCSE_Database.
    /// </summary>
    /// <param name="database">CTSCSE_Database value.</param>
    /// <param name="noise">A ::CTSCSE_Noise value. Если значение равно CTSCSENoise_MAX, шум не применяется.</param>
    /// <returns>ECG_HEADER pointer, если метод был успешным. NULL в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern IntPtr MECGLoadDatabaseCTS_CSE(
      [param: MarshalAs(UnmanagedType.U4)] Enum_CTSCSE_Database database, 
      [param: MarshalAs(UnmanagedType.U4)] Enum_CTSCSE_Noise noise);

    /// <summary>
    /// Загрузить периодическую форму сигнала
    /// Непрерывно выводить форму сигнала, пока не будет вызван MECGStopOutput.
    /// </summary>
    /// <param name="waveform"></param>
    /// <param name="frequency">Частота Единица измерения: Гц. Разрешение: 0,01 Гц. Диапазон: 0~100 Гц.</param>
    /// <param name="amplitude">амплитуда Амплитуда напряжение. Единица измерения: мВpp.
    ///</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGLoadWaveform(
      [param: MarshalAs(UnmanagedType.U4)] Enum_WAVEFORM_TYPE waveform, 
      double frequency, 
      double amplitude);

    /// <summary>
    /// Загрузить периодическую форму сигнала
    /// Непрерывно выводить форму сигнала, пока не будет вызван MECGStopOutput.
    /// </summary>
    /// <param name="waveform"></param>
    /// <param name="frequency">частота Частота. Единица: Гц. Разрешение: 0,01 Гц. Диапазон: 0~100 Гц.</param>
    /// <param name="amplitude">амплитуда Амплитуда напряжение. Единица: мВpp. 8 записей расположены в порядке LeadI, LeadII, V1~V6.</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGLoadWaveformEx([param: MarshalAs(UnmanagedType.U4)] Enum_WAVEFORM_TYPE waveform, 
      double frequency, 
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 8)] double[] amplitude);

    /// <summary>
    /// Загрузить треугольную форму сигнала 
    /// Непрерывно выводить форму сигнала, пока не будет вызван MECGStopOutput.
    /// </summary>
    /// <param name="pulseWidth">Ширина импульса. Единица: мс</param>
    /// <param name="frequency">частота Частота. Единица: Гц. Разрешение: 0,01 Гц. Диапазон: 0~100 Гц.</param>
    /// <param name="amplitude">амплитуда Амплитуда напряжение. Единица: мВpp</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGLoadWaveformRectanglePulse(
      int pulseWidth, 
      double frequency, 
      double amplitude);

    /// <summary>
    /// Загрузить сигнал режима калибровки 
    /// Загруженный сигнал имеет фиксированную длину 10 секунд. 
    /// Используется в процессе калибровки.
    /// </summary>
    /// <param name="frequency">частота Частота. Единица измерения: Гц. Разрешение: 0,01 Гц. Диапазон: 0~100 Гц.</param>
    /// <param name="amplitude">амплитуда Амплитуда напряжение. Единица измерения: мВpp</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGLoadWaveformCalibrationMode(
      double frequency, 
      double amplitude);

    /// <summary>
    /// Загрузить форму сигнала в режиме автоматической калибровки.
    ///
    /// Загруженная форма сигнала фиксируется на 10-секундной длине. Используется в процессе калибровки.
    /// </summary>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGLoadWaveformAutoCalibrationMode();

    /// <summary>
    /// Получить сигналы формы волны.
    /// Вызывающий может получить текущие сигналы формы волны для использования в качестве наблюдателя.
    /// </summary>
    /// <param name="start">start Начальная позиция ожидаемых сигналов. Единица измерения: секунда</param>
    /// <param name="duration">duration Длительность ожидаемых сигналов. Единица измерения: секунда</param>
    /// <param name="outputSignalCB">outputSignalCB Функция обратного вызова, которая будет вызвана с возвращенными сигналами.</param>
    /// <returns>True, если метод был успешным. False, если outputSignalCB равен NULL или данные формы волны пусты</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGGetWaveformSignal(
      int start, 
      int duration, 
      FPtrOutputSignalCallback outputSignalCB);

    /// <summary>
    /// Включить/выключить режим цикла
    /// </summary>
    /// <param name="enable">True, если ожидается режим цикла. False в противном случае.</param>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern void MECGEnableLoop(bool enable);

    /// <summary>
    /// Включить/выключить шумовой сигнал.
    /// Шумовой сигнал эффективен только если форма волны нагрузки — CTS/CSE.
    /// </summary>
    /// <param name="enable">True, если ожидается шум. False в противном случае.</param>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern void MECGEnableNoise(bool enable);

    /// <summary>
    /// Уведомить устройство о начале вывода
    /// </summary>
    /// <param name="startPosition">Начальная позиция для воспроизведения. Единица: секунда</param>
    /// <param name="outputSignalCB">Функция обратного вызова, которая возвращает сигналы ЭКГ по 12 отведениям</param>
    /// <param name="outputDelayCB">Функция обратного вызова, которая возвращает время задержки, если произошла задержка передачи пакета</param>
    /// <returns>True, если метод был успешным. False в противном случае.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    protected static extern bool MECGOutputWaveform(
      int startPosition, 
      FPtrOutputSignalExCallback outputSignalCB = null, 
      FPtrOutputDelayCallback outputDelayCB = null);

    /// <summary>
    /// Остановите вывод устройства.
    /// </summary>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern void MECGStopOutput();

    /// <summary>
    /// Получить версию файла DLL
    /// </summary>
    /// <returns>Версия состоит из 4 цифр и сохраняется в каждом байте беззнакового целого значения.
    /// Например, если возвращаемое значение равно 0x01020304, версия dll равна 1.2.3.4.</returns>
    [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    protected static extern Int32 MECGGetVersion();

    #endregion
  }
}
