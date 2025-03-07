using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Cardiograph.Services.Controller.MECG.structs;

namespace Test_Cardiograph.Services.Model.Stages.descendant.Command.descendant
{
  /// <summary>
  /// Тест модель которая содержит в себе ссылки на заголовочный ЭКГ файл хранящийся в MECG20.
  /// </summary>
  class TestModel_CTSCSE
  {
    /// <summary>
    /// База данных.
    /// </summary>
    public Enum_CTSCSE_Database database { get; set; }

    /// <summary>
    /// Дополнительные параметры записи. Шумы.
    /// </summary>
    public Enum_CTSCSE_Noise noise { get; set; }
  }
}
