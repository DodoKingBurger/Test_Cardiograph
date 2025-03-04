using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cardiograph.Services.Controller.MECG.structs
{
  /// <summary>
  /// Фильтр шумов
  /// </summary>
  public enum CTSCSE_Noise : int
  {
    /// <summary>
    /// 50Hz noise 25uV peak
    /// </summary>
    [Description("50Hz noise 25uV peak")] CTSCSENoise_50HZ = 0,

    /// <summary>
    /// 60Hz noise 25uV peak
    /// </summary>
    [Description("60Hz noise 25uV peak")] CTSCSENoise_60HZ = 1,

    /// <summary>
    /// Baseline noise 0.3Hz 0.5mV peak
    /// </summary>
    [Description("Baseline noise 0.3Hz 0.5mV peak")] CTSCSENoise_BL = 2,

    /// <summary>
    /// Baseline noise 0.3Hz 0.5mV peak + HF noise 15uVrms
    /// </summary>
    [Description("Baseline noise 0.3Hz 0.5mV peak + HF noise 15uVrms")] CTSCSENoise_BL_HF = 3,

    /// <summary>
    /// HF noise 05uVrms
    /// </summary>
    [Description("HF noise 05uVrms")] CTSCSENoise_HF_05 = 4,

    /// <summary>
    /// HF noise 10uVrms
    /// </summary>
    [Description("HF noise 10uVrms")] CTSCSENoise_HF_10 = 5,       

    /// <summary>
    /// HF noise 15uVrms
    /// </summary>
    [Description("HF noise 15uVrms")] CTSCSENoise_HF_15 = 6,

    /// <summary>
    /// HF noise 20uVrms
    /// </summary>
    [Description("HF noise 20uVrms")] CTSCSENoise_HF_20 = 7,

    /// <summary>
    /// HF noise 25uVrms
    /// </summary>
    [Description("HF noise 25uVrms")] CTSCSENoise_HF_25 = 8,

    /// <summary>
    /// HF noise 30uVrms
    /// </summary>
    [Description("HF noise 30uVrms")] CTSCSENoise_HF_30 = 9,

    /// <summary>
    /// HF noise 35uVrms
    /// </summary>
    [Description("HF noise 35uVrms")] CTSCSENoise_HF_35 = 10,

    /// <summary>
    /// HF noise 40uVrms
    /// </summary>
    [Description("HF noise 40uVrms")] CTSCSENoise_HF_40 = 11,

    /// <summary>
    /// HF noise 45uVrms
    /// </summary>
    [Description("HF noise 45uVrms")] CTSCSENoise_HF_45 = 12,
    
    /// <summary>
    /// HF noise 50uVrms
    /// </summary>
    [Description("HF noise 50uVrms")] CTSCSENoise_HF_50 = 13,

    /// <summary>
    /// Noise Off
    /// </summary>
    [Description("Noise Off")] CTSCSENoise_MAX = 14
  }
}
