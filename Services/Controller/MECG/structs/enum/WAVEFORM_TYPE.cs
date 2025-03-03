using System;
using System.Collections.Generic;
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
    WaveformSine,

    /// <summary>
    /// Форма волныТреугольник,
    /// </summary>
    WaveformTriangle,
    
    /// <summary>
    /// Форма волны Квадрат
    /// </summary>
    WaveformSquare
  }
}
