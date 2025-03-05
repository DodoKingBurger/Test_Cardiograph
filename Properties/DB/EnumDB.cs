using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cardiograph.Properties.DB
{
  /// <summary>
  /// База данных ЭКГ.
  /// </summary>
  public enum EnumDB
  {
    /// <summary>
    /// CTS Атлас.
    /// </summary>
    [Description("Атлас CTS")]
    CTS,

    /// <summary>
    /// Европейская CSE.
    /// </summary>
    [Description("Европейская CSE")]
    CSE,

    /// <summary>
    /// Проект тестовой базы РОХМИНЭ
    /// </summary>
    [Description("РОХМИНЭ")]
    РОХМИНЭ,

    /// <summary>
    /// БД Аксиона.
    /// </summary>
    [Description("AXION")]
    AXION
  }
}
