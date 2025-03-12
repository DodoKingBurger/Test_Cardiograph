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
    /// Путь к папке с БД. Просто подставь название папки;
    /// </summary>
    private string pathFolderDB = string.Join("\\", Environment.CurrentDirectory.Split('\\'), 0, Environment.CurrentDirectory.Split('\\').Length - 3) + $"\\Properties\\DB\\";

    /// <summary>
    /// Загружает по выбранной вариации заголовочный файл ЭКГ в МЕКГ.
    /// </summary>
    /// <param name="database">выбранный из списка вариант ЭКГ.</param>
    /// <param name="noise">Список шумов.</param>
    public delegate void LoadECG_CTSCSE(Enum_CTSCSE_Database database, Enum_CTSCSE_Noise noise);

    /// <summary>
    /// Загрзука в МЕКГ файла из БД Атласа (CTS) или Европейской (CSE).
    /// </summary>
    public event LoadECG_CTSCSE? Load_CTSCSEFile;

    /// <summary>
    /// Делегат для получение ЭКГ из файла по пути.
    /// </summary>
    /// <param name="filepath">Путь к файлу.</param>
    public delegate void LoadECG_FromFile(string filepath);

    /// <summary>
    /// Получение ЭКГ из файла по пути.
    /// </summary>
    public event LoadECG_FromFile? Load_ECGFile;

    /// <summary>
    /// Отправка значений в главную форму для формирования ТestModel
    /// </summary>
    /// <param name="waveForm"></param>
    /// <param name="freaquency"></param>
    /// <param name="amplitude"></param>
    public delegate void LoadECG_WaveForm(Enum_WAVEFORM_TYPE waveForm, double freaquency, double amplitude);

    /// <summary>
    /// Получения варианта ЭКГ с разными формами волны.
    /// </summary>
    public event LoadECG_WaveForm? Load_WaveFormFile;

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
      tableLayoutPanel_NoisePanel.Visible = false;
      splitContainer_Other_Parametrs.Visible = false;
      checkedListBox_DB_Noise.DataSource = Enum.GetValues(typeof(Enum_CTSCSE_Noise))
        .OfType<Enum_CTSCSE_Noise>().Select(val => EnumWorcker.GetDescription(val)).ToArray();
      comboBox_List_DB.Items.AddRange(Enum.GetValues(typeof(EnumDB))
        .OfType<EnumDB>().Select(val => EnumWorcker.GetDescription(val)).ToArray());
    }

    /// <summary>
    /// Закрытие формы.
    /// </summary>
    /// <param name="sender">Форма.</param>
    /// <param name="e">Закрытие.</param>
    private void DB_CTSCSE_DBForm_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    /// <summary>
    /// Отправка в главную форму выбранного варинта.
    /// </summary>
    /// <param name="sender">Кнопка.</param>
    /// <param name="e">Click.</param>
    private void button_Choise_ECG_Click(object sender, EventArgs e)
    {
      switch (EnumWorcker.EnumValueOf(comboBox_List_DB.SelectedItem.ToString(), typeof(EnumDB)))
      {
        case EnumDB.CSE:
          Send_CTSCSE();
          break;
        case EnumDB.CTS:
          Send_CTSCSE();
          break;
        case EnumDB.РОХМИНЭ:
          Send_ROHMiN();
            break;
        case EnumDB.AXION:
          Send_AXION();
          break;
        case EnumDB.WaveForm:
          Send_Waveform();
          break;
        default:
          throw new ArgumentException("Неизвестный выбранный элемент.");
      }
      Close();
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
      if (comboBox_List_DB.SelectedIndex != -1)
      {
        var dv = checkedListBox_Database.DataSource as DataView;
        var filter = textBox_SearchName.Text.Trim().Length >= 0
            ? $"Item LIKE '{textBox_SearchName.Text}*'"
            : null;

        dv.RowFilter = filter;

        for (var i = 0; i < checkedListBox_Database.Items.Count; i++)
        {
          var drv = checkedListBox_Database.Items[i] as DataRowView;
          var chk = Convert.ToBoolean(drv["Checked"]);
          checkedListBox_Database.SetItemChecked(i, chk);
        }
      }
    }

    /// <summary>
    /// Изменение выбранного индекса в выподающем списке.
    /// </summary>
    /// <param name="sender">comboBox.</param>
    /// <param name="e">Выбор индекса.</param>
    private void comboBox_List_DB_SelectedIndexChanged(object sender, EventArgs e)
    {
      System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
      if (EnumWorcker.EnumValueOf(comboBox.SelectedItem.ToString(), typeof(EnumDB)).Equals(EnumDB.CSE) || EnumWorcker.EnumValueOf(comboBox.SelectedItem.ToString(), typeof(EnumDB)).Equals(EnumDB.CTS))
      {
        tableLayoutPanel_NoisePanel.Visible = true;
      }
      else
      {
        tableLayoutPanel_NoisePanel.Visible = false;
      }
      switch (EnumWorcker.EnumValueOf(comboBox.SelectedItem.ToString(), typeof(EnumDB)))
      {
        case EnumDB.CSE:
          tableLayoutPanel_NoisePanel.Visible = true;
          break;
        case EnumDB.CTS:
          tableLayoutPanel_NoisePanel.Visible = true;
          break;
        case EnumDB.WaveForm:
          splitContainer_Other_Parametrs.Visible = true;
          break;
        default:
          tableLayoutPanel_NoisePanel.Visible = false;
          splitContainer_Other_Parametrs.Visible = false;
          break;
      }
      var elArray = DBEnumMeneger.LoadListDBName((EnumDB)EnumWorcker.EnumValueOf(comboBox.SelectedItem.ToString(), typeof(EnumDB)));
      var dt = new DataTable();
      dt.Columns.Add("Item", typeof(string));
      dt.Columns.Add("Checked", typeof(bool));
      foreach (var item in elArray) dt.Rows.Add(item, false);
      dt.AcceptChanges();
      checkedListBox_Database.DataSource = dt.DefaultView;
      checkedListBox_Database.DisplayMember = "Item";
      checkedListBox_Database.ValueMember = "Item";
      // If not already done by the designer...
      checkedListBox_Database.ItemCheck += resultBoxList_ItemCheck;
    }

    /// <summary>
    /// Открывает диалогове окно для выбора загрузки *hea файла.
    /// </summary>
    /// <param name="sender">Кнопка.</param>
    /// <param name="e">Клик.</param>
    private void button_Load_File_Click(object sender, EventArgs e)
    {
      openFileDialog.FileName = "";
      openFileDialog.Filter = "ECG_Header (*.hea)|*.hea| All files (*.*)|*.*";
      openFileDialog.InitialDirectory = pathFolderDB;

      if (openFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      if (!openFileDialog.FileName.Equals(string.Empty))
      {// получаем выбранный файл
        Load_ECGFile(openFileDialog.FileName);
        Close();
      }
    }

    #endregion

    #region Методы отправки данных в форму

    /// <summary>
    /// Функция вызовет нужное событие по отрпавки ECG из базы MECG. 
    /// </summary>
    private void Send_CTSCSE()
    {
      Enum_CTSCSE_Database cTSCSE = new Enum_CTSCSE_Database();
      Enum_CTSCSE_Noise cTSCSE_Noise = new Enum_CTSCSE_Noise();

      if (checkedListBox_Database.CheckedItems.Count == 1)
      {
        cTSCSE = (Enum_CTSCSE_Database)EnumWorcker.EnumValueOf(checkedListBox_Database.SelectedValue.ToString(), typeof(Enum_CTSCSE_Database));
      }
      else
        cTSCSE = Enum_CTSCSE_Database.CTSCSE_MAX;

      if(checkedListBox_DB_Noise.CheckedItems.Count == 1)
      {
        cTSCSE_Noise = (Enum_CTSCSE_Noise)EnumWorcker.EnumValueOf(checkedListBox_DB_Noise.SelectedValue.ToString(), typeof(Enum_CTSCSE_Noise));
      }
      else
        cTSCSE_Noise = Enum_CTSCSE_Noise.CTSCSENoise_MAX;
      Load_CTSCSEFile(cTSCSE, cTSCSE_Noise);
    }

    /// <summary>
    /// Функция вызовет событие по отправки данных о форме волны.
    /// </summary>
    private void Send_Waveform()
    {
      Enum_WAVEFORM_TYPE type = new Enum_WAVEFORM_TYPE();
      if (checkedListBox_Database.CheckedItems.Count == 1)
      {
        type = (Enum_WAVEFORM_TYPE)EnumWorcker.EnumValueOf(checkedListBox_Database.SelectedValue.ToString(), typeof(Enum_WAVEFORM_TYPE));
      }
      else
        type = Enum_WAVEFORM_TYPE.WaveformSine;
      Load_WaveFormFile(type, (double)numericUpDown_Frequency.Value, (double)numericUpDown_Amplitude.Value);
    }

    /// <summary>
    /// Функция вызовет событие по отправки данных ROHMiN в форме ...
    /// Думаю что работа как с чтением файла.
    /// </summary>
    private void Send_ROHMiN()
    {
      SearchFile("ROHMINE");
    }

    /// <summary>
    /// Функция вызовет событие по отправки данных ROHMiN в форме ...
    /// Думаю что работа как с чтением файла.
    /// </summary>
    private void Send_AXION()
    {
      SearchFile("AXION");
    }

    #endregion

    /// <summary>
    /// Функция для события обновления.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void resultBoxList_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      var dv = checkedListBox_Database.DataSource as DataView;
      var drv = dv[e.Index];
      drv["Checked"] = e.NewValue == CheckState.Checked ? true : false;
    }

    /// <summary>
    /// Осуществляет пойск файла по его названию.
    /// </summary>
    /// <param name="nameFile"></param>
    /// <returns></returns>
    private void SearchFile(string NameFolder)
    {
      if (checkedListBox_Database.CheckedItems.Count == 1)
      {
        if (File.Exists(this.pathFolderDB + $"{NameFolder}\\{checkedListBox_Database.SelectedValue}"))
        {
          Load_ECGFile(this.pathFolderDB + $"{NameFolder}\\{checkedListBox_Database.SelectedValue}");
        }
        else
          MessageBox.Show("Не найден такой файл");
      }
      else
        MessageBox.Show("Файл не выбран");
    }


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
