using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Cardiograph.Services.Controller.MECG.structs;
using Test_Cardiograph.Services.Model.Stages.descendant.Test;

namespace Test_Cardiograph.Services.Model.Stages.descendant.Command.descendant
{
  /// <summary>
  /// Тест модель которая содержит в себе уже сформированный заголовочный ЭКГ файл
  /// </summary>
  public class TestModel_ECG_Header : TestModel
  {
    /// <summary>
    /// Заголовочный файл ЭКГ.
    /// </summary>
    public ECG_HEADER HEADER { get; set; }
  }
}
