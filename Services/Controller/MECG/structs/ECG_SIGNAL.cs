﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cardiograph.Services.Controller.MECG.structs
{
  /// <summary>
  /// ЭКГ Сигнал
  /// </summary>
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
  public struct ECG_SIGNAL
  {
    /// <summary>
    /// Signal description
    ///  Описание сигнала
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] Description;

    /// <summary>
    ///  По умолчанию отведение для сопоставления будет настроено соответствующим образом.
    ///  By default, the mapping lead will be configured appropriately.
    /// </summary>
    public ECG_Lead MappingLead;               
  }
}
