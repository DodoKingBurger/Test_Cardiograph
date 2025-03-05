using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Cardiograph.Services.Controller.MECG.structs;

namespace Test_Cardiograph.Services.Model
{
  /// <summary>
  /// Модель теста кардиографа.
  /// </summary>
  public class TestModel
  {
    /// <summary>
    /// Имя теста.
    /// </summary>
    public string NameTest { get; set; }

    /// <summary>
    /// Заголовочный файл ЭКГ.
    /// </summary>
    public ECG_HEADER HEADER { get; set; } 
  
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
          this.wR = value;
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
      get { return wr; }
      set
      {
        if (!value.Equals(null) && value >= 0)
        {
          this.wR = value;
        }
        else
          throw new ArgumentException("wR = null или меньше 0");
      }
    }
  }
}
