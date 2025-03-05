using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        default:
          throw new Exception("Неизвестная БД.");

      }
    }

    private static string[] LoadNameCTS()
    {
        return Enum.GetValues(typeof(CTSCSE_Database))
        .OfType<CTSCSE_Database>().Select(val => GetDescription(val)).Take(18).ToArray();
    }

    private static string[] LoadNameCTE()
    {
      return Enum.GetValues(typeof(CTSCSE_Database))
      .OfType<CTSCSE_Database>().Select(val => GetDescription(val)).Skip(18).ToArray();
    }
    private static string[] LoadNameAXION()
    {
      return new string[] {"1","2","3" };
    }
    private static string[] LoadNameROHMINE()
    {
      return new string[] { "1", "6", "0", "0" };
    }

    /// <summary>
    /// Returns the Enumeration value that has a given Description attribute.
    /// </summary>
    /// <param name="value">The Description attribute value.</param>
    /// <param name="enumType">The type of enumeration in which to search.</param>
    /// <returns>The enumeration value that matches the Description value provided.</returns>
    /// <exception cref="ArgumentException">Thrown when the specified Description value is not found with in the provided Enumeration Type.</exception>
    public static object EnumValueOf(string value, Type enumType)
    {
      string[] names = Enum.GetNames(enumType);
      foreach (string name in names)
      {
        if (GetDescription((Enum)Enum.Parse(enumType, name)).Equals(value))
        {
          return Enum.Parse(enumType, name);
        }
      }
      throw new ArgumentException("The string is not a description or value of the specified enum.");
    }

    /// <summary>
    /// Расшифровка enuma
    /// </summary>
    /// <param name="value">Enum value</param>
    /// <returns>Описание.</returns>
    public static string GetDescription(Enum value)
    {
      FieldInfo field = value.GetType().GetField(value.ToString());
      object[] attribs = field.GetCustomAttributes(typeof(DescriptionAttribute), true);
      if (attribs.Length > 0)
      {
        return ((DescriptionAttribute)attribs[0]).Description;
      }
      return string.Empty;
    }
  }
}
