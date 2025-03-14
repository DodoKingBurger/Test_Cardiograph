﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test_Cardiograph.Properties.DB;
using Test_Cardiograph.Services.Controller.MECG.structs;
using static System.Net.WebRequestMethods;

namespace Test_Cardiograph.Services.StaticClass
{
  /// <summary>
  /// Работа (ну вывадвать их названия для списка в частности) с базой данных ЭКГ.
  /// </summary>
  static class DBEnumMeneger
  {
    #region Поля и свойства

    /// <summary>
    /// Массив строк для получения из *txt файла данных.
    /// </summary>
    static string[] strings= new string[] { };

    #endregion

    #region Методы

    /// <summary>
    /// Возвращает имена доступных записей в БД.
    /// </summary>
    /// <param name="enumDB">Название БД.</param>
    /// <returns>массив строк названий для вывода на экран.</returns>
    public static string[] LoadListDBName(EnumDB enumDB)
    {
      switch (enumDB)
      {
        case EnumDB.CTS:
          return LoadNameCTS();
        case EnumDB.CSE:
          return LoadNameCTE();
        case EnumDB.AXION:
          return LoadNameAXION();
        case EnumDB.РОХМИНЭ:
          return LoadNameROHMINE();
        case EnumDB.WaveForm:
            return LoadNameWaveForm();
        default:
          throw new Exception("Неизвестная БД.");

      }
    }

    /// <summary>
    /// Загрузка в список названий БД CTS атласа.
    /// </summary>
    /// <returns>Названия БД.</returns>
    private static string[] LoadNameCTS()
    {
        return Enum.GetValues(typeof(Enum_CTSCSE_Database))
        .OfType<Enum_CTSCSE_Database>().Select(val => EnumWorcker.GetDescription(val)).Take(19).ToArray();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>Названия БД.</returns>
    private static string[] LoadNameCTE()
    {
      return Enum.GetValues(typeof(Enum_CTSCSE_Database))
      .OfType<Enum_CTSCSE_Database>().Select(val => EnumWorcker.GetDescription(val)).Skip(19).ToArray();
    }

    /// <summary>
    /// Загрузка БД из папки AXION.
    /// </summary>
    /// <returns>Названия БД.</returns>
    private static string[] LoadNameAXION()
    {
      List<string> FileName = new List<string>(); 
      foreach(var str in Directory.GetFiles(string.Join("\\", Environment.CurrentDirectory.Split('\\'), 0, Environment.CurrentDirectory.Split('\\').Length - 3) + $"\\Properties\\DB\\AXION", "*.hea"))
      {
        FileName.Add(str.Split('\\').Last());
      }
      return FileName.ToArray();
    }

    /// <summary>
    /// Загрузка БД из папки РОХМиНЭ.
    /// </summary>
    /// <returns>Названия БД.</returns>
    private static string[] LoadNameROHMINE()
    {
      string path = String.Join("\\",
      AppDomain.CurrentDomain.BaseDirectory.Split('\\')
      [0..(AppDomain.CurrentDomain.BaseDirectory.Split('\\').Count() - 4)])
      + "\\Properties\\DB\\ROHMINE\\Result.txt";

      if (!System.IO.File.Exists(path))
        throw new FileNotFoundException("Файл с именем Result.txt не найден");
      strings = System.IO.File.ReadAllText(path).Split(new char[] { '\n', '\t' }).Where((num, index) => (index % 2 == 0 && num.Length>0)).ToArray();
      return strings;
    }

    /// <summary>
    /// Возвращает список возможных Форм волн.
    /// </summary>
    /// <returns>Список возможных Форм волн.</returns>
    private static string[] LoadNameWaveForm()
    {
      return Enum.GetValues(typeof(Enum_WAVEFORM_TYPE))
      .OfType<Enum_WAVEFORM_TYPE>().Select(val => EnumWorcker.GetDescription(val)).ToArray();
    }

    #endregion
  }
}
