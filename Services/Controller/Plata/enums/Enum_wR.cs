using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cardiograph.Services.Controller.Plata
{
  /// <summary>
  /// Список возможных сопротивлений с генератора.
  /// </summary>
  public enum Enum_wR : int
  {
    [Description("0")]
    R0 = 0,

    [Description("10")]
    R10 = 1,

    [Description("50")]
    R50 = 2,

    [Description("100")]
    R100 = 3,

    [Description("150")]
    R150 = 4,

    [Description("200")]
    R200 = 5,

    [Description("250")]
    R250 = 6,

    [Description("300")]
    R300 = 7,

    [Description("400")]
    R400 = 8,

    [Description("500")]
    R500 = 9,

    [Description("600")]
    R600 = 10,

    [Description("700")]
    R700 = 11,

    [Description("800")]
    R800 = 12,

    [Description("900")]
    R900 = 13,

    [Description("1000")]
    R1000 = 14
  }
}
