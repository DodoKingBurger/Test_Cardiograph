using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cardiograph.Services.Controller.Plata
{
  /// <summary>
  /// Список возможных дельта сопротивлений с генератора.
  /// </summary>
  public enum Enum_dR: int
  {
    [Description("0,025")]
    R0025 = 0,

    [Description("0,05")]
    R005 = 1,

    [Description("0,1")]
    R01 = 2,

    [Description("0,2")]
    R02 = 3,

    [Description("0,4")]
    R04 = 4,

    [Description("0,5")]
    R05 = 5,

    [Description("1,0")]
    R1 = 6,

    [Description("1,5")]
    R15 = 7,

    [Description("2,0")]
    R20 = 8
  }
}
