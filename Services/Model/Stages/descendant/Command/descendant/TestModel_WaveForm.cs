using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Cardiograph.Services.Controller.MECG.structs;

namespace Test_Cardiograph.Services.Model.Stages.descendant.Command.descendant
{
  /// <summary>
  /// Тест модель которая содержит в себе поле с форматом волны.
  /// </summary>
  public class TestModel_WaveForm
  {
    /// <summary>
    /// Форма волны.
    /// </summary>
    public WAVEFORM_TYPE Type { get; set; }

    /// <summary>
    /// Частота волны.
    /// </summary>
    public double Frequency { get; set; }

    /// <summary>
    /// Амплитуда волны.
    /// </summary>
    public double Amplitude { get; set; }
  }
}
