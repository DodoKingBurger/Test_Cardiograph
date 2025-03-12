using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Test_Cardiograph.Services.Controller.MECG.structs;
using Test_Cardiograph.Services.Model.Stages.descendant.Command.descendant;

namespace Test_Cardiograph.Services.Model.Stages.descendant.Test
{
  /// <summary>
  /// Модель теста кардиографа.
  /// </summary>
  [JsonDerivedType(typeof(TestModel), typeDiscriminator: "TestModel_")]
  [JsonDerivedType(typeof(TestModel_CTSCSE), typeDiscriminator: "TestModel_CTSCSE")]
  [JsonDerivedType(typeof(TestModel_ECG_Header), typeDiscriminator: "TestModel_ECG_Header")] 
  [JsonDerivedType(typeof(TestModel_WaveForm), typeDiscriminator: "TestModel_WaveForm")]
  public class TestModel : Stages
  {
  
    /// <summary>
    /// Нужно ли контролировать ЧСС пациента.
    /// </summary>
    public bool ControlCHSS { get; set; }

    private int chss;
    
    /// <summary>
    /// ЧСС пациента.
    /// </summary>
    public int CHSS 
    { 
      get { return this.chss; }
      set
      {
        if (value > 500 || value <= 0)
          throw new ArgumentException("ЧСС задан нереалистичный.");
        else
          this.chss = value;
      }
    }

    /// <summary>
    /// Нужно ли контролировать пневмограмму.
    /// </summary>
    public bool ControlPneumogram { get; set; }

    private float dr;

    /// <summary>
    /// ΔR
    /// </summary>
    public float dR
    {
      get { return this.dr; }
      set
      {
        if (!value.Equals(null) && value >= 0)
        {
          this.dr = value;
        }
        else
          throw new ArgumentException("wR = null или меньше 0");
      }
    }

    private float wr;

    /// <summary>
    /// ΩR
    /// </summary>
    public float wR
    {
      get { return this.wr; }
      set
      {
        if (!value.Equals(null) && value >= 0)
        {
          this.wr = value;
        }
        else
          throw new ArgumentException("wR = null или меньше 0");
      }
    }
  }
}
