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
  public enum EnumOptionsStages
  {
    /// <summary>
    /// Команды (тесты) взаимодествие с измерениями.
    /// </summary>
    [Description("Команды")]
    Command,

    /// <summary>
    /// Уведомления пользователя, то есть диктовка его действий.
    /// </summary>
    [Description("Уведомление пользователя")]
    Notifications,

    /// <summary>
    /// Уведомления пользователя, то есть диктовка его действий, с дальнейшим подтвержением что все прошло правильно.
    /// </summary>
    [Description("Уведомление пользователя, с подтверждением")]
    NotificationsConfirmation
  }
}
