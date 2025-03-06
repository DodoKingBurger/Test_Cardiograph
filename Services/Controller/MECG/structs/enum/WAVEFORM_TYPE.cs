using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cardiograph.Services.Controller.MECG.structs
{
  /// <summary>
  /// ТИП_ФОРМЫ_ВОЛНЫ
  /// </summary>
  public enum WAVEFORM_TYPE
  {
    /// <summary>
    /// Форма волныСинус,
    /// </summary>
    [Description("Синусоидальный")]
    WaveformSine,

    /// <summary>
    /// Форма волныТреугольник,
    /// </summary>
    [Description("Треугольный")]
    WaveformTriangle,

    /// <summary>
    /// Форма волны Квадрат
    /// </summary>
    [Description("Квадратный")]
    WaveformSquare
  }
}
