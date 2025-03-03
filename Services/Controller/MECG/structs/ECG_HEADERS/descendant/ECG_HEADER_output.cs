using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cardiograph.Services.Controller.MECG.structs
{
  /// <summary>
  /// ЭКГ_ ЗАГОЛОВОК
  /// </summary>
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
  public class ECG_HEADER_output : dll_ECG_HEADER
  {

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
    private ECG_SIGNAL[] signal;
    /// <summary>
    /// Размер Signal[] задается NumberOfSignals is given by NumberOfSignals
    /// </summary>
    public ECG_SIGNAL[] Signal
    {
      get
      {
        if (!signal.Equals(null))
          return signal;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
      set
      {
        if (!value.Equals(null))
          signal = value;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
    }


    /// <summary>
    /// Метод для получения массива сигналов
    /// </summary>
    /// <returns>массива сигналов</returns>
    public ECG_SIGNAL[] GetInputSignalArray()
    {
      if (this.Signal == null || NumberOfSignals <= 0)
        throw new ArgumentNullException("ECG_SIGNAL if null ref");

      // Создаем массив сигналов
      ECG_SIGNAL[] signalArray = new ECG_SIGNAL[this.NumberOfSignals];

      // Копируем данные из неуправляемой памяти в управляемый массив
      for (long i = 0; i < this.NumberOfSignals; i++)
      {
        signalArray[i] = Signal[i];
      }

      return signalArray;
    }
  }
}
