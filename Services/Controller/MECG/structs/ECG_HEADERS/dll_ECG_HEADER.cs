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
  public class dll_ECG_HEADER
  {
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    private byte[] recordName;
    /// <summary>
    /// Имя записи формы волны ЭКГ
    /// </summary>
    public byte[] RecordName
    {
      get
      {
        if (!recordName.Equals(null))
          return recordName;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
      set
      {
        if (!value.Equals(null))
          recordName = value;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
    }

    private Int32 numberOfSignals;
    /// <summary>
    /// Количество сигналов; размер массива Signal[]
    /// </summary>
    public Int32 NumberOfSignals
    {
      get
      {
        if (!numberOfSignals.Equals(null))
          return numberOfSignals;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
      set
      {
        if (!value.Equals(null))
          numberOfSignals = value;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
    }

    private Int32 samplingFrequency;
    /// <summary>
    /// Выборок в секунду на сигнал.
    /// </summary>
    public Int32 SamplingFrequency
    {
      get
      {
        if (!samplingFrequency.Equals(null))
          return samplingFrequency;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
      set
      {
        if (!value.Equals(null))
          samplingFrequency = value;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
    }

    private Int32 numberOfSamplesPerSignal;
    /// <summary>
    /// Количество выборок на сигнал.
    /// </summary>
    public Int32 NumberOfSamplesPerSignal
    {
      get
      {
        if (!numberOfSamplesPerSignal.Equals(null))
          return numberOfSamplesPerSignal;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
      set
      {
        if (!value.Equals(null))
          numberOfSamplesPerSignal = value;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
    }

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    private byte[] reserved;
    /// <summary>
    /// Внутреннее использование. Вызывающий не должен его изменять.
    /// </summary>
    public byte[] Reserved
    {
      get
      {
        if (!reserved.Equals(null))
          return reserved;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
      set
      {
        if (!value.Equals(null))
          reserved = value;
        else
          throw new ArgumentNullException("ECG_SIGNAL if null ref");
      }
    }

  }
}
