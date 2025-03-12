using System.Data;
using System.Text.Json;
using System.Windows.Forms;
using D_DCharLists;
using Test_Cardiograph.Controller;
using Test_Cardiograph.Properties.DB;
using Test_Cardiograph.Services.Controller.MECG.structs;
using Test_Cardiograph.Services.Controller.Plata;
using Test_Cardiograph.Services.Model.Stages;
using Test_Cardiograph.Services.Model.Stages.descendant.Command.descendant;
using Test_Cardiograph.Services.Model.Stages.descendant.Notifications;
using Test_Cardiograph.Services.Model.Stages.descendant.Notifications_confirmation;
using Test_Cardiograph.Services.Model.Stages.descendant.Test;
using Test_Cardiograph.Services.StaticClass;
using Test_Cardiograph.Services.view;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.Design.AxImporter;
using static Test_Cardiograph.Services.view.DB_CTSCSE_DBForm;

namespace Test_Cardiograph
{
  public partial class MainForm : Form
  {
    #region Поля и свойства

    /// <summary>
    /// Форма с базой данных прибора MECG20
    /// </summary>
    private DB_CTSCSE_DBForm cTSCSE_DB { get; set; }

    /// <summary>
    /// Контроллер для работ с тесттером.
    /// </summary>
    private MECG MECG20;

    /// <summary>
    /// Список тестов и присущий им порядковый номер.
    /// </summary>
    public List<Stages> Stages;

    public Dictionary<string, List<Stages>> Checks;

    /// <summary>
    /// Выбранный тест для редактирования.
    /// </summary>
    public Stages SelectedTest;

    /// <summary>
    /// Индекс последнего выбранного теста.
    /// </summary>
    private int Cursore = 1;

    #endregion

    #region Методы

    /// <summary>
    /// Загрузка формы.
    /// </summary>
    /// <param name="sender">Форма.</param>
    /// <param name="e">Загрузка формы.</param>
    private void MainForm_Load(object sender, EventArgs e)
    {
      MECG20 = new MECG();
      numericUpDown_Heart_Rate_Control.Enabled = false;
      tableLayoutPanel_Pneumogram.Enabled = false;
      comboBox_Type_Command_View.Items.AddRange(Enum.GetValues(typeof(EnumOptionsStages))
        .OfType<EnumOptionsStages>().Select(val => EnumWorcker.GetDescription(val)).ToArray());
      comboBox_del_R.Items.AddRange(Enum.GetValues(typeof(Enum_dR))
  .OfType<Enum_dR>().Select(val => EnumWorcker.GetDescription(val)).ToArray());
      comboBox_Omega_R.Items.AddRange(Enum.GetValues(typeof(Enum_wR))
  .OfType<Enum_wR>().Select(val => EnumWorcker.GetDescription(val)).ToArray());

      //string text = "Noti.json\nNoti_Comp.json";
      //File.WriteAllText("C:\\soft\\Тест каридограф\\WinForms\\Test_Cardiograph\\Properties\\Checks\\Noti.txt", text);
      SearchDBTXTFile();
    }



    /// <summary>
    /// Вызов формы для выбора из БД ЭКГ.
    /// </summary>
    /// <param name="sender">Кнопка.</param>
    /// <param name="e">Клик.</param>
    private void button_Choice_ECG_Header_Click(object sender, EventArgs e)
    {
      cTSCSE_DB = new DB_CTSCSE_DBForm();
      cTSCSE_DB.Load_CTSCSEFile += LoadDatabaseCTS_CSE;
      cTSCSE_DB.Load_ECGFile += LoadECG_FromFile;
      cTSCSE_DB.Load_WaveFormFile += LoadECG_WaveForm;
      cTSCSE_DB.ShowDialog();
    }

    /// <summary>
    /// поидее будет переключателем тип, начать там тестирования остановить, продолжить чет тип такого.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button_Worker_Test_Click(object sender, EventArgs e)
    {

    }

    #region CRUD и функции для него

    /// <summary>
    /// Кнопка для сохранения выбранного этапа в список этапов.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="Exception"></exception>
    private void button_Save_Selected_Stage_Click(object sender, EventArgs e)
    {
      var stage = (Stages)FillingStage();
      if (!this.Stages.Contains(stage))
      {
        this.Stages.Insert(0, stage);
      }
      else
      {
        this.Stages[this.Stages.IndexOf(stage)] = stage;
      }
      View_List_Stage();
    }

    private void button_Delete_Selected_Stage_Click(object sender, EventArgs e)
    {
      if (this.Stages.Contains(this.SelectedTest))
      {
        this.Stages.Remove(this.SelectedTest);
        View_List_Stage();
      }
      else
        MessageBox.Show("Такой этап уже существует.");
    }

    /// <summary>
    /// Заполнение этапа.
    /// </summary>
    /// <returns>Этап.</returns>
    /// <exception cref="Exception"></exception>
    private object FillingStage()
    {
      ////Пока выглядит ужасно, надо как то резать.
      switch (EnumWorcker.EnumValueOf(comboBox_Type_Command_View.SelectedItem.ToString(), typeof(EnumOptionsStages)))
      {
        case EnumOptionsStages.Command:
          if (this.SelectedTest is TestModel test)
          {
            test.NameStage = textBox_Name_Stage.Text;
            test.ControlCHSS = checkBox_Heart_Rate_Control.Checked;
            if (test.ControlCHSS)
              test.CHSS = ((int)numericUpDown_Heart_Rate_Control.Value);
            test.ControlPneumogram = checkBox_Pneumogram.Checked;
            if (test.ControlPneumogram)
            {
              //я сомневаюсь, надо список вариантов записать если что валидацию прикрутим.
              test.dR = float.Parse(comboBox_del_R.SelectedItem.ToString());
              test.wR = float.Parse(comboBox_Omega_R.SelectedItem.ToString());
            }
            return test;
          }
          return null;
        case EnumOptionsStages.Notifications:
          return new Stage_Notifications() { NameStage = textBox_Name_Stage.Text, Notifications = textBox_Create_Notifications.Text };

        case EnumOptionsStages.NotificationsConfirmation:
          return new Stage_Notifications_Confirmation() { NameStage = textBox_Name_Stage.Text, Notifications_Confirmation = textBox_Notifications_Confirmation.Text };
        default:
          throw new Exception("Выберите тип Этапа");
      }
    }

    #endregion

    #region Визуальные изменения формы 

    /// <summary>
    /// Нужно ли отслеживать ЧСС.
    /// </summary>
    /// <param name="sender">Чек бокс.</param>
    /// <param name="e">Изменения состояния чек бокса.</param>
    private void checkBox_Heart_Rate_Control_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox_Heart_Rate_Control.Checked)
        numericUpDown_Heart_Rate_Control.Enabled = true;
      else
        numericUpDown_Heart_Rate_Control.Enabled = false;
    }

    /// <summary>
    /// Нужно ли отслеживать пневмограмму.
    /// </summary>
    /// <param name="sender">Чек бокс.</param>
    /// <param name="e">Изменения состояния чек бокса.</param>
    private void checkBox_Pneumogram_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox_Pneumogram.Checked)
        tableLayoutPanel_Pneumogram.Enabled = true;
      else
        tableLayoutPanel_Pneumogram.Enabled = false;
    }

    /// <summary>
    /// Переместить выбранный, в списке этапов, этап на индекс --
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button_Up_Click(object sender, EventArgs e)
    {
      if (this.Stages.Any())
      {
        if (this.Stages.Contains(this.SelectedTest))
        {
          if (this.Cursore > 0)
          {
            this.Stages.Remove(this.SelectedTest);
            this.Cursore -= 1;
            this.Stages.Insert(this.Cursore, this.SelectedTest);
          }
          else
          {
            MessageBox.Show("Этап первый в списке");
          }
          View_List_Stage();
        }
        else
          MessageBox.Show("Такого этапа нету в списке.");
      }
      else
        MessageBox.Show("Список этапов пуст");
    }

    /// <summary>
    /// Переместить выбранный, в списке этапов, курсор на индекс ++
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button_Down_Click(object sender, EventArgs e)
    {
      if (this.Stages.Any())
      {
        if (this.Stages.Contains(this.SelectedTest))
        {
          if (this.Cursore < this.Stages.Count - 1)
          {
            this.Stages.Remove(this.SelectedTest);
            this.Cursore += 1;
            this.Stages.Insert(this.Cursore, this.SelectedTest);
          }
          else
            MessageBox.Show("Этап последний в списке");
          View_List_Stage();
        }
        else
          MessageBox.Show("Такого этапа нету в списке.");
      }
      else
        MessageBox.Show("Список этапов пуст");
    }

    /// <summary>
    /// выбор этапа.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ListView_List_Stage_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (e.NewValue == CheckState.Checked)
      {
        this.Cursore = e.Index;
        this.SelectedTest = this.Stages[this.Cursore];
        ViewSelectedStage();
      }
    }

    /// <summary>
    /// Тут бы как бы почистить 
    /// Ну вообще функция должна выводить информацию о выбранном этапе.
    /// </summary>
    private void ViewSelectedStage()
    {
      textBox_Name_Stage.Text = this.SelectedTest.NameStage;
      if (this.SelectedTest is TestModel test)
      {
        groupBox_CreateTest.Visible = true;
        groupBox_Create_Notifications.Visible = false;
        groupBox_Notifications_Confirmation.Visible = false;
        comboBox_Type_Command_View.SelectedIndex = 0;
        if (test.ControlCHSS)
        {
          checkBox_Heart_Rate_Control.Checked = true;
          numericUpDown_Heart_Rate_Control.Value = test.CHSS;
        }
        if (test.ControlPneumogram)
        {
          checkBox_Pneumogram.Checked = true;
          comboBox_del_R.SelectedIndex = (int)EnumWorcker.GetIndexEnum_dR(test.dR);
          comboBox_Omega_R.SelectedIndex = (int)EnumWorcker.GetIndexEnum_wR(test.wR);
        }
      }
      else if (this.SelectedTest is Stage_Notifications notifications)
      {
        comboBox_Type_Command_View.SelectedIndex = 1;
        groupBox_CreateTest.Visible = false;
        groupBox_Create_Notifications.Visible = true;
        groupBox_Notifications_Confirmation.Visible = false;
        textBox_Create_Notifications.Text = notifications.Notifications;
      }
      else if (this.SelectedTest is Stage_Notifications_Confirmation notifications_Confirmation)
      {
        comboBox_Type_Command_View.SelectedIndex = 2;
        groupBox_CreateTest.Visible = false;
        groupBox_Create_Notifications.Visible = false;
        groupBox_Notifications_Confirmation.Visible = true;
        textBox_Notifications_Confirmation.Text = notifications_Confirmation.Notifications_Confirmation;
      }
    }

    /// <summary>
    /// Тут будет згрзука файла с базой этапов.
    /// </summary>
    public void View_List_Stage()
    {
      if (this.Stages.Any())
      {
        ListViewItem[] breakfast = new ListViewItem[] { };
        if (this.ListView_List_Stage.CheckedItems.Count > 0)
        {
          breakfast = new ListViewItem[this.ListView_List_Stage.CheckedItems.Count];
          int i = 0;
          foreach (ListViewItem a in ListView_List_Stage.CheckedItems)
          {
            breakfast[i] = a;
            i++;
          }
        }
        ListView_List_Stage.Clear();
        int counter = 0;
        foreach (var row in this.Stages)
        {
          var roww = new ListViewItem($"{row.NameStage}");
          if (breakfast.Length > 0)
          {
            if (ContainsInList(breakfast, roww))
            {
              ListView_List_Stage.Items.Add(roww);
              ListView_List_Stage.Items[counter].Checked = true;
            }
            else
            {
              ListView_List_Stage.Items.Add(roww);
            }
            counter++;
          }
          else
            ListView_List_Stage.Items.Add(roww);
        }
      }
      else
        MessageBox.Show("Список пуст.");
    }

    /// <summary>
    /// Перебирает список, и ищет там совпадение с переданным ListViewItem по названию.
    /// </summary>
    /// <param name="list">Список.</param>
    /// <param name="view">обьект для пойска.</param>
    /// <returns>True, если совпадение найдено, иначе false/</returns>
    private bool ContainsInList(ListViewItem[] list, ListViewItem view)
    {
      foreach (var row in list)
      {
        if (row.Text.ToLower().Equals(view.Text.ToLower()))
        {
          return true;
        }
      }
      return false;
    }

    #endregion

    #region Методы для отправки в другие формы

    /// <summary>
    /// Загрузка выбранной из БД заголовочного файла ECG. Для события.
    /// </summary>
    /// <param name="Database">База данных CTSCSE</param>
    /// <param name="noise">Фильтр шумов.</param>
    private void LoadDatabaseCTS_CSE(Enum_CTSCSE_Database database, Enum_CTSCSE_Noise noise)
    {
      try
      {
        this.SelectedTest = new TestModel();
        //database был с явным приведением к типу (int) почему то не дает явно передать что database конвертится в инт
        //this.MECG20.LoadDatabaseCTS_CSE(database, noise);
        this.SelectedTest = new TestModel_CTSCSE() { Database = database, Noise = noise };
        //MECG20.Output_waveform(0);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    /// <summary>
    /// Загрузка ЭКГ по полученному пути к файлу. Для события.
    /// </summary>
    /// <param name="filepath">Путь к файлу.</param>
    private void LoadECG_FromFile(string filepath)
    {
      try
      {
        this.SelectedTest = new TestModel();
        if (!string.IsNullOrEmpty(filepath))
        {
          this.MECG20.Save_header(filepath);
          this.SelectedTest = new TestModel_ECG_Header() { HEADER = this.MECG20.Header };
        }
        else
          throw new ArgumentException("Путь был передан не корректно.");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    /// <summary>
    /// Получения варианта ЭКГ с разными формами волны.
    /// </summary>
    /// <param name="waveForm"></param>
    /// <param name="freaquency"></param>
    /// <param name="amplitude"></param>
    private void LoadECG_WaveForm(Enum_WAVEFORM_TYPE waveForm, double freaquency, double amplitude)
    {
      try
      {
        this.SelectedTest = new TestModel();
        this.SelectedTest = new TestModel_WaveForm() { Type = waveForm, Frequency = freaquency, Amplitude = amplitude };
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    #endregion

    private void SearchDBTXTFile()
    {
      foreach (var str in DBChecksMeneger.LoadNameTXTFile())
      {
        listView_List_Checks.Items.Add(str);
      }
    }

    #endregion

    #region Конструктор

    public MainForm()
    {
      InitializeComponent();
    }

    #endregion

    private void listView_List_Checks_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (e.NewValue == CheckState.Checked)
      {
        this.Stages = JsonSaveLoad.JsonLoadList(listView_List_Checks.Items[e.Index].Text);
        View_List_Stage();
      }
    }
  }
}
