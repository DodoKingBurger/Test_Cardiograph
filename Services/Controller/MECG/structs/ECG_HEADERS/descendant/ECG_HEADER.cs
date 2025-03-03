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
  public class ECG_HEADER : dll_ECG_HEADER
  {
    #region Поля и свойства

    [MarshalAs(UnmanagedType.ByValArray)]
    private ECG_SIGNAL[]? signal;
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

    #endregion

    #region Конструкторы

    public ECG_HEADER()
    {

    }

    public ECG_HEADER(ECG_HEADER_output? hEADER_Output)
    {
      if(hEADER_Output != null)
      {
        this.RecordName = hEADER_Output.RecordName;
        this.NumberOfSignals = hEADER_Output.NumberOfSignals;
        this.SamplingFrequency = hEADER_Output.SamplingFrequency;
        this.NumberOfSamplesPerSignal = hEADER_Output.NumberOfSamplesPerSignal;
        this.Reserved = hEADER_Output.Reserved;
        this.Signal = hEADER_Output.GetInputSignalArray();
      }
    }

    #endregion
  }
}

