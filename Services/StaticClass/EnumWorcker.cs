using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test_Cardiograph.Services.Controller.MECG.structs;

namespace Test_Cardiograph.Services.StaticClass
{
  static class EnumWorcker
  {

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

    /// <summary>
    /// Возвращает выбранынй элемент из переданного listBox
    /// </summary>
    /// <param name="sender">CheckedListBox список выбранный итемов.</param>
    /// <param name="enums">Список из какого проверять CTSCSE_Noise или CTSCSE_Database</param>
    /// <returns>Возвращает выбранынй элемент из переданного listBox.</returns>
    public static object GetEnumName(CheckedListBox sender, Type enums)
    {
      if (enums.Name == typeof(Enum_CTSCSE_Noise).Name)
      {
        switch (sender.CheckedItems.Count)
        {
          case 1:
            return EnumValueOf(sender.CheckedItems[0].ToString(), typeof(Enum_CTSCSE_Noise));
          default:
            return EnumValueOf(sender.Items[14].ToString(), typeof(Enum_CTSCSE_Noise));
        }
      }
      else if (enums.Name == typeof(Enum_CTSCSE_Database).Name)
      {
        switch (sender.SelectedItems.Count)
        {
          case 1:
            return EnumValueOf(sender.CheckedItems[0].ToString(), typeof(Enum_CTSCSE_Database));
          default:
            return EnumValueOf(sender.Items[119].ToString(), typeof(Enum_CTSCSE_Database));
        }
      }
      else
        throw new ArgumentException("Enum неизвестного типа.");
    }
  }
}
