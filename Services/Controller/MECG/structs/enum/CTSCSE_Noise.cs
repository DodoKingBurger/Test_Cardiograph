using System;
using System.Collections.Generic;
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
    CTSCSENoise_50HZ = 0,       

    /// <summary>
    /// 60Hz noise 25uV peak
    /// </summary>
    CTSCSENoise_60HZ = 1,        

    /// <summary>
    /// Baseline noise 0.3Hz 0.5mV peak
    /// </summary>
    CTSCSENoise_BL = 2, 

    /// <summary>
    /// Baseline noise 0.3Hz 0.5mV peak + HF noise 15uVrms
    /// </summary>
    CTSCSENoise_BL_HF = 3,

    /// <summary>
    /// HF noise 05uVrms
    /// </summary>
    CTSCSENoise_HF_05 = 4,

    /// <summary>
    /// HF noise 10uVrms
    /// </summary>
    CTSCSENoise_HF_10 = 5,       

    /// <summary>
    /// HF noise 15uVrms
    /// </summary>
    CTSCSENoise_HF_15 = 6,

    /// <summary>
    /// HF noise 20uVrms
    /// </summary>
    CTSCSENoise_HF_20 = 7,

    /// <summary>
    /// HF noise 25uVrms
    /// </summary>
    CTSCSENoise_HF_25 = 8,

    /// <summary>
    /// HF noise 30uVrms
    /// </summary>
    CTSCSENoise_HF_30 = 9,

    /// <summary>
    /// HF noise 35uVrms
    /// </summary>
    CTSCSENoise_HF_35 = 10,

    /// <summary>
    /// HF noise 40uVrms
    /// </summary>
    CTSCSENoise_HF_40 = 11,

    /// <summary>
    /// HF noise 45uVrms
    /// </summary>
    CTSCSENoise_HF_45 = 12,
    
    /// <summary>
    /// HF noise 50uVrms
    /// </summary>
    CTSCSENoise_HF_50 = 13,

    /// <summary>
    /// Noise Off
    /// </summary>
    CTSCSENoise_MAX = 14
  }
}
