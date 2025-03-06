using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cardiograph.Services.Model.Stages
{
  /// <summary>
  /// Этап испытаний, из Этапов состоит Проверки. 
  /// То есть Проверка это список этапов.
  /// ПСИ и ПИ это список этапов.
  /// </summary>
  public abstract class Stages
  {
    /// <summary>
    /// Имя Этапа.
    /// </summary>
    public string NameTest { get; set; }
  }
}
