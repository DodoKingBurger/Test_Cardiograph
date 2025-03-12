using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Test_Cardiograph.Services.Model.Stages.descendant.Notifications;
using Test_Cardiograph.Services.Model.Stages.descendant.Notifications_confirmation;
using Test_Cardiograph.Services.Model.Stages.descendant.Test;

namespace Test_Cardiograph.Services.Model.Stages
{
  /// <summary>
  /// Этап испытаний, из Этапов состоит Проверки. 
  /// То есть Проверка это список этапов.
  /// ПСИ и ПИ это список этапов.
  /// </summary>
  [JsonDerivedType(typeof(Stages), typeDiscriminator: "Stages")]
  [JsonDerivedType(typeof(TestModel), typeDiscriminator: "TestModel")]
  [JsonDerivedType(typeof(Stage_Notifications), typeDiscriminator: "Stage_Notifications")]
  [JsonDerivedType(typeof(Stage_Notifications_Confirmation), typeDiscriminator: "Stage_Notifications_Confirmation")]
  public class Stages
  {
    /// <summary>
    /// Имя Этапа.
    /// </summary>
    public string NameStage { get; set; }

    /// <summary>
    /// Тип Этапа. Использую для костыля с расшифровкой из JSON
    /// </summary>
    public EnumStagesType stagesType { get; set; }
  }
}
