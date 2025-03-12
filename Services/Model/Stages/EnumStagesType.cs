using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cardiograph.Services.Model.Stages
{
  /// <summary>
  /// Списиок возможных типов Этапа.
  /// </summary>
  public enum EnumStagesType
  {
    /// <summary>
    /// Этап с файлом из базы данных MECG20.
    /// </summary>
    [Description("TestModel_CTSCSE")]
    TestModel_CTSCSE = 0,

    /// <summary>
    /// Этап с загруженным файлом ECG_Header.
    /// </summary>
    [Description("TestModel_ECG_Header")] 
    TestModel_ECG_Header = 1,

    /// <summary>
    /// Этап с какой то формой на выбор.
    /// </summary>
    [Description("TestModel_WaveForm")]
    TestModel_WaveForm = 2,

    /// <summary>
    /// Уведомления пользователя, то есть диктовка его действий.
    /// </summary>
    [Description("Notifications")]
    Notifications = 3,

    /// <summary>
    /// Уведомления пользователя, то есть диктовка его действий, с дальнейшим подтвержением что все прошло правильно.
    /// </summary>
    [Description("NotificationsConfirmation")]
    Notifications_Confirmation = 4
  }
}

