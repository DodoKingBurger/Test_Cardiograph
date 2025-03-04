using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Test_Cardiograph.Services.Controller.MECG.structs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test_Cardiograph.Services.view
{
  public partial class DB_CTSCSE_DB : Form
  {
    #region Поля и свойства

    /// <summary>
    /// Делегат для события обновления базы данных на экарне.
    /// </summary>
    public delegate void LoadDatabaseCTS_CSE(CTSCSE_Database database, CTSCSE_Noise noise);

    /// <summary>
    /// Обновление базы данных предметов на главном экране.
    /// </summary>
    public event LoadDatabaseCTS_CSE? Notify;

    #endregion

    #region Методы

    #region События формы

    /// <summary>
    /// Загрузка формы.
    /// </summary>
    /// <param name="sender">Форма.</param>
    /// <param name="e"></param>
    private void DB_CTSCSE_DB_Load(object sender, EventArgs e)
    {
      checkedListBox_DB_Noise.DataSource = Enum.GetValues(typeof(CTSCSE_Noise))
        .OfType<CTSCSE_Noise>().Select(val => GetDescription(val)).ToArray();
      checkedListBox_CTSCSE_Database.DataSource = Enum.GetValues(typeof(CTSCSE_Database))
        .OfType<CTSCSE_Database>().Select(val => GetDescription(val)).ToArray();
    }

    /// <summary>
    /// Загрузка выбранного варинта.
    /// </summary>
    /// <param name="sender">Кнопка.</param>
    /// <param name="e"></param>
    private void button_Load_Waveform_Click(object sender, EventArgs e)
    {
      try
      {
        if (!Notify.Equals(null))
        {
          Notify((CTSCSE_Database)GetEnumName(checkedListBox_CTSCSE_Database, typeof(CTSCSE_Database)),
            (CTSCSE_Noise)GetEnumName(checkedListBox_DB_Noise, typeof(CTSCSE_Noise)));
        }
        else
          throw new NullReferenceException("Ошибка отправки, событие не было переданно");
      }
      catch (Exception ex)
      {
        MessageBox.Show($"{ex.Message}");
      }
    }

    /// <summary>
    /// Валлидация колличества выбранных элементов в списке.
    /// </summary>
    /// <param name="sender">checkedListBox.</param>
    /// <param name="e">Событие по выбору итема.</param>
    private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      var control = (CheckedListBox)sender;
      if (e.NewValue == CheckState.Checked)
      {
        for (int ix = 0; ix < control.Items.Count; ++ix)
        {
          if (e.Index != ix) control.SetItemChecked(ix, false);
        }
      }
    }

    #endregion

    #region Доп методы 

    /// <summary>
    /// Возвращает выбранынй элемент из переданного listBox
    /// </summary>
    /// <param name="sender">CheckedListBox список выбранный итемов.</param>
    /// <param name="enums">Список из какого проверять CTSCSE_Noise или CTSCSE_Database</param>
    /// <returns></returns>
    public object GetEnumName(CheckedListBox sender, Type enums)
    {
      if (enums.Name == typeof(CTSCSE_Noise).Name)
      {
        switch (sender.CheckedItems.Count)
        {
          case 1:
            return EnumValueOf(sender.CheckedItems[0].ToString(), typeof(CTSCSE_Noise));
          default:
            return EnumValueOf(sender.Items[14].ToString(), typeof(CTSCSE_Noise));
        }
      }
      else if (enums.Name == typeof(CTSCSE_Database).Name)
      {
        switch (sender.SelectedItems.Count)
        {
          case 1:
            return EnumValueOf(sender.CheckedItems[0].ToString(), typeof(CTSCSE_Database));
          default:
            return EnumValueOf(sender.Items[119].ToString(), typeof(CTSCSE_Database));
        }
      }
      else
        throw new ArgumentException("Enum неизвестного типа.");
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

    #endregion

    #endregion

    #region Констуркторы

    public DB_CTSCSE_DB()
    {
      InitializeComponent();
    }

    #endregion
  }
}
