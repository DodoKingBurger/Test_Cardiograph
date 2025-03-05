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
using Test_Cardiograph.Properties.DB;
using Test_Cardiograph.Services.Controller.MECG.structs;
using Test_Cardiograph.Services.Model;
using Test_Cardiograph.Services.StaticClass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test_Cardiograph.Services.view
{
  public partial class DB_CTSCSE_DBForm : Form
  {
    #region Поля и свойства

    /// <summary>
    /// Загружает по выбранной вариации заголовочный файл ЭКГ в МЕКГ.
    /// </summary>
    /// <param name="database">выбранный из списка вариант ЭКГ.</param>
    /// <param name="noise">Список шумов.</param>
    public delegate void LoadDatabaseCTS_CSE(CTSCSE_Database database, CTSCSE_Noise noise);

    /// <summary>
    /// Загрзука в МЕКГ файла из БД Атласа (CTS) или Европейской (CSE).
    /// </summary>
    public event LoadDatabaseCTS_CSE? LoadFileCTSCSE;

    /// <summary>
    /// Делегат для получение ЭКГ из файла по пути.
    /// </summary>
    /// <param name="filepath">Путь к файлу.</param>
    /// <returns>Заголовочный файл ЭКГ.</returns>
    public delegate ECG_HEADER LoadECG_FromFile(string filepath);

    /// <summary>
    /// Получение ЭКГ из файла по пути.
    /// </summary>
    public event LoadECG_FromFile? LoadECG;

    #endregion

    #region Методы

    #region События формы

    /// <summary>
    /// Загрузка формы.
    /// </summary>
    /// <param name="sender">Форма.</param>
    /// <param name="e">Load.</param>
    private void DB_CTSCSE_DB_Load(object sender, EventArgs e)
    {
      checkedListBox_DB_Noise.Visible = false;
      checkedListBox_DB_Noise.DataSource = Enum.GetValues(typeof(CTSCSE_Noise))
        .OfType<CTSCSE_Noise>().Select(val => EnumWorcker.GetDescription(val)).ToArray();
      comboBox_List_DB.Items.AddRange(Enum.GetValues(typeof(EnumDB))
        .OfType<EnumDB>().Select(val => EnumWorcker.GetDescription(val)).ToArray());
    }

    /// <summary>
    /// Загрузка выбранного варинта.
    /// </summary>
    /// <param name="sender">Кнопка.</param>
    /// <param name="e">Click.</param>
    private void button_Load_Waveform_Click(object sender, EventArgs e)
    {
      try
      {
        if (!LoadFileCTSCSE.Equals(null))
        {
          LoadFileCTSCSE((CTSCSE_Database)EnumWorcker.GetEnumName(checkedListBox_Database, typeof(CTSCSE_Database)),
            (CTSCSE_Noise)EnumWorcker.GetEnumName(checkedListBox_DB_Noise, typeof(CTSCSE_Noise)));
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

    /// <summary>
    /// Пойск по названию в выведенной базе ЭКГ.
    /// </summary>
    /// <param name="sender">TextBox.</param>
    /// <param name="e">Изменение текста в контроле.</param>
    private void textBox_SearchName_TextChanged(object sender, EventArgs e)
    {
      //checkedListBox_Database.Items.Contains();
    }

    /// <summary>
    /// Изменение выбранного индекса в выподающем списке.
    /// </summary>
    /// <param name="sender">comboBox.</param>
    /// <param name="e">Выбор индекса.</param>
    private void comboBox_List_DB_SelectedIndexChanged(object sender, EventArgs e)
    {
      System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;

      checkedListBox_Database.DataSource = DBEnumMeneger.LoadListDBName((EnumDB)EnumWorcker.EnumValueOf(comboBox.SelectedItem.ToString(), typeof(EnumDB)));
      if(EnumWorcker.EnumValueOf(comboBox.SelectedItem.ToString(), typeof(EnumDB)).Equals(EnumDB.CSE)|| EnumWorcker.EnumValueOf(comboBox.SelectedItem.ToString(), typeof(EnumDB)).Equals(EnumDB.CTS))
      {
        checkedListBox_DB_Noise.Visible = true;

      }
      else
      {
        checkedListBox_DB_Noise.Visible = false;
      }
    }

    /// <summary>
    /// Открывает диалогове окно для выбора загрузки *hea файла.
    /// </summary>
    /// <param name="sender">Кнопка.</param>
    /// <param name="e">Клик.</param>
    private void button_Load_hea_File_Click(object sender, EventArgs e)
    {
      if (EnumWorcker.EnumValueOf(comboBox_List_DB.SelectedItem.ToString(), typeof(EnumDB)).Equals(EnumDB.CSE) || EnumWorcker.EnumValueOf(comboBox_List_DB.SelectedItem.ToString(), typeof(EnumDB)).Equals(EnumDB.CTS))
      {

      }
    }
    #endregion

    #endregion

    #region Констуркторы

    public DB_CTSCSE_DBForm()
    {
      InitializeComponent();
    }

    #endregion

    #region NOT_USED

    //    checkedListBox_DB_Noise.DataSource = Enum.GetValues(typeof(CTSCSE_Noise))
    //.OfType<CTSCSE_Noise>().Select(val => EnumWorcker.GetDescription(val)).ToArray();
    //    checkedListBox_Database.DataSource = Enum.GetValues(typeof(CTSCSE_Database))
    //      .OfType<CTSCSE_Database>().Select(val => EnumWorcker.GetDescription(val)).ToArray();

    #endregion
  }
}
