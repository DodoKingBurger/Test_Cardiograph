using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test_Cardiograph.Properties.DB;
using Test_Cardiograph.Services.Controller.MECG.structs;

namespace Test_Cardiograph.Services.StaticClass
{
  /// <summary>
  /// Работа с базой данных.
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
        return Enum.GetValues(typeof(CTSCSE_Database))
        .OfType<CTSCSE_Database>().Select(val => EnumWorcker.GetDescription(val)).Take(19).ToArray();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>Названия БД.</returns>
    private static string[] LoadNameCTE()
    {
      return Enum.GetValues(typeof(CTSCSE_Database))
      .OfType<CTSCSE_Database>().Select(val => EnumWorcker.GetDescription(val)).Skip(19).ToArray();
    }

    /// <summary>
    /// Загрузка БД из папки AXION.
    /// </summary>
    /// <returns>Названия БД.</returns>
    private static string[] LoadNameAXION()
    {
      return new string[] {"1","2","3" };
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
      var task = ReadROHMINE_File(path);
      if (File.Exists(path))
      {
        MessageBox.Show("Я видеть Result");
        
      }


      return strings;
    }

    /// <summary>
    /// Открывает *txt файл.
    /// </summary>
    /// <param name="path">Путь к файлу.</param>
    public static async Task ReadROHMINE_File(string path)
    {
      using (StreamReader reader = new StreamReader(path))
      {
        string text = await reader.ReadToEndAsync();
        strings = text.Split(new char[] { '\n', '\t' }).Where((num, index) => index % 2 == 0).ToArray();
      }
    }

    /// <summary>
    /// Возвращает список возможных Форм волн.
    /// </summary>
    /// <returns>Список возможных Форм волн.</returns>
    private static string[] LoadNameWaveForm()
    {
      return Enum.GetValues(typeof(WAVEFORM_TYPE))
      .OfType<WAVEFORM_TYPE>().Select(val => EnumWorcker.GetDescription(val)).ToArray();
    }

    #endregion
  }
}
