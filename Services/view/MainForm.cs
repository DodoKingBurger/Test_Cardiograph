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
    #region ���� � ��������

    /// <summary>
    /// ����� � ����� ������ ������� MECG20
    /// </summary>
    private DB_CTSCSE_DBForm cTSCSE_DB { get; set; }

    /// <summary>
    /// ���������� ��� ����� � ���������.
    /// </summary>
    private MECG MECG20;

    /// <summary>
    /// ������ ������ � �������� �� ���������� �����.
    /// </summary>
    public List<Stages> Stages;

    public Dictionary<string, List<Stages>> Checks;

    /// <summary>
    /// ��������� ���� ��� ��������������.
    /// </summary>
    public Stages SelectedTest;

    /// <summary>
    /// ������ ���������� ���������� �����.
    /// </summary>
    private int Cursore = 1;

    #endregion

    #region ������

    /// <summary>
    /// �������� �����.
    /// </summary>
    /// <param name="sender">�����.</param>
    /// <param name="e">�������� �����.</param>
    private void MainForm_Load(object sender, EventArgs e)
    {
      MECG20 = new MECG();
      textbox_Heart_Rate_Control.Enabled = false;
      tableLayoutPanel_Pneumogram.Enabled = false;
      comboBox_Type_Command_View.Items.AddRange(Enum.GetValues(typeof(EnumOptionsStages))
        .OfType<EnumOptionsStages>().Select(val => EnumWorcker.GetDescription(val)).ToArray());
      comboBox_del_R.Items.AddRange(Enum.GetValues(typeof(Enum_dR))
  .OfType<Enum_dR>().Select(val => EnumWorcker.GetDescription(val)).ToArray());
      comboBox_Omega_R.Items.AddRange(Enum.GetValues(typeof(Enum_wR))
  .OfType<Enum_wR>().Select(val => EnumWorcker.GetDescription(val)).ToArray());

      //string text = "Noti.json\nNoti_Comp.json";
      //File.WriteAllText("C:\\soft\\���� ����������\\WinForms\\Test_Cardiograph\\Properties\\Checks\\Noti.txt", text);
      SearchDBTXTFile();
    }

    /// <summary>
    /// ����� ����� ��� ������ �� �� ���.
    /// </summary>
    /// <param name="sender">������.</param>
    /// <param name="e">����.</param>
    private void button_Choice_ECG_Header_Click(object sender, EventArgs e)
    {
      cTSCSE_DB = new DB_CTSCSE_DBForm();
      cTSCSE_DB.Load_CTSCSEFile += LoadDatabaseCTS_CSE;
      cTSCSE_DB.Load_ECGFile += LoadECG_FromFile;
      cTSCSE_DB.Load_WaveFormFile += LoadECG_WaveForm;
      cTSCSE_DB.ShowDialog();
    }

    /// <summary>
    /// ������ ����� �������������� ���, ������ ��� ������������ ����������, ���������� ��� ��� ������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button_Worker_Test_Click(object sender, EventArgs e)
    {

    }

    #region CRUD � ������� ��� ����

    /// <summary>
    /// ������ ��� ���������� ���������� ����� � ������ ������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="Exception"></exception>
    private void button_Save_Selected_Stage_Click(object sender, EventArgs e)
    {
      var stage = (Stages)FillingStage();
      if (this.Stages.Where(x => x.NameStage == stage.NameStage).ToList().Count == 0)
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
        MessageBox.Show("����� ���� ��� ����������.");
    }

    /// <summary>
    /// ���������� �����.
    /// </summary>
    /// <returns>����.</returns>
    /// <exception cref="Exception"></exception>
    private object FillingStage()
    {
      ////���� �������� ������, ���� ��� �� ������.
      switch (EnumWorcker.EnumValueOf(comboBox_Type_Command_View.SelectedItem.ToString(), typeof(EnumOptionsStages)))
      {
        case EnumOptionsStages.Command:
          if (this.SelectedTest is TestModel model)
          { 
            return FactoryTestModel(model);
          }
          return null;
        case EnumOptionsStages.Notifications:
          return new Stage_Notifications() { NameStage = textBox_Name_Stage.Text, Notifications = textBox_Create_Notifications.Text };

        case EnumOptionsStages.NotificationsConfirmation:
          return new Stage_Notifications_Confirmation() { NameStage = textBox_Name_Stage.Text, Notifications_Confirmation = textBox_Notifications_Confirmation.Text };
        default:
          throw new Exception("�������� ��� �����");
      }
    }

    /// <summary>
    /// ���������� ���� � ���� ��� ������������ ���� ����� ������ ����� ������ ���
    /// </summary>
    /// <param name="test"></param>
    /// <returns></returns>
    private object FactoryTestModel(TestModel test)
    {
      if(test != null)
      {
        switch (test.stagesType)
        {
          case EnumStagesType.TestModel_WaveForm:
            if (test is TestModel_WaveForm wave)
              return new TestModel_WaveForm()
              {
                stagesType = EnumStagesType.TestModel_WaveForm,
                Type = wave.Type,
                Amplitude = wave.Amplitude,
                Frequency = wave.Frequency,
                NameStage = textBox_Name_Stage.Text,
                ControlCHSS = checkBox_Heart_Rate_Control.Checked,
                CHSS = (int.Parse(textbox_Heart_Rate_Control.Text)),
                ControlPneumogram = checkBox_Pneumogram.Checked,
                dR = float.Parse(comboBox_del_R.SelectedItem.ToString()),
                wR = float.Parse(comboBox_Omega_R.SelectedItem.ToString())
              };
            else
              throw new Exception("test not TestModel_WaveForm");
          case EnumStagesType.TestModel_ECG_Header:
            if (test is TestModel_ECG_Header header)
              return new TestModel_ECG_Header()
              {
                stagesType = EnumStagesType.TestModel_ECG_Header,
                HEADER = header.HEADER
              };
            else
              throw new Exception("test not TestModel_ECG_Header");
          case EnumStagesType.TestModel_CTSCSE:
            if (test is TestModel_CTSCSE ctsCse)
              return new TestModel_CTSCSE()
              {
                stagesType = EnumStagesType.TestModel_CTSCSE,
                Database = ctsCse.Database,
                Noise = ctsCse.Noise
              };
            else
              throw new Exception("test not TestModel_CTSCSE");
          default:
            throw new Exception("����������� ��� �����.");
        }
      }
      throw new ArgumentNullException("���� ����!");
    }
    #endregion

    #region ���������� ��������� ����� 

    /// <summary>
    /// ��������� ������� �����
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void textbox_Heart_Rate_Control_TextChanged(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(textbox_Heart_Rate_Control.Text))
      {
        if(!int.TryParse(textbox_Heart_Rate_Control.Text, out int CHSS))
        {
          textbox_Heart_Rate_Control.Clear();
          MessageBox.Show("������ ���� ������� ������ ����� �����.");
        }
      }
    }

    /// <summary>
    /// ����� �� ����������� ���.
    /// </summary>
    /// <param name="sender">��� ����.</param>
    /// <param name="e">��������� ��������� ��� �����.</param>
    private void checkBox_Heart_Rate_Control_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox_Heart_Rate_Control.Checked)
        textbox_Heart_Rate_Control.Enabled = true;
      else
        textbox_Heart_Rate_Control.Enabled = false;
    }

    /// <summary>
    /// ����� �� ����������� ������������.
    /// </summary>
    /// <param name="sender">��� ����.</param>
    /// <param name="e">��������� ��������� ��� �����.</param>
    private void checkBox_Pneumogram_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox_Pneumogram.Checked)
        tableLayoutPanel_Pneumogram.Enabled = true;
      else
        tableLayoutPanel_Pneumogram.Enabled = false;
    }

    /// <summary>
    /// ����������� ���������, � ������ ������, ���� �� ������ --
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
            MessageBox.Show("���� ������ � ������");
          }
          View_List_Stage();
        }
        else
          MessageBox.Show("������ ����� ���� � ������.");
      }
      else
        MessageBox.Show("������ ������ ����");
    }

    /// <summary>
    /// ����������� ���������, � ������ ������, ������ �� ������ ++
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
            MessageBox.Show("���� ��������� � ������");
          View_List_Stage();
        }
        else
          MessageBox.Show("������ ����� ���� � ������.");
      }
      else
        MessageBox.Show("������ ������ ����");
    }

    /// <summary>
    /// ����� �����.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ListView_List_Stage_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (e.NewValue == CheckState.Checked)
      {
        this.Cursore = e.Index;
        var test = this.Stages[this.Cursore];
        this.SelectedTest = test;
        ViewSelectedStage();
      }
      else
      {
        if (ListView_List_Stage.CheckedItems.Count - 1 == 0)
        {
          tableLayoutPanel1.Visible = false;
          groupBox_CreateTest.Visible = false;
          groupBox_Create_Notifications.Visible = false;
          groupBox_Notifications_Confirmation.Visible = false;
        }
        else if (ListView_List_Stage.CheckedItems.Count - 1 > 0)
        {
          this.Cursore = ListView_List_Stage.CheckedItems.Count - 1;
          var test = this.Stages[this.Cursore];
          this.SelectedTest = test;
          ViewSelectedStage();
        }
      }
    }

    /// <summary>
    /// ����� ��������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void listView_List_Checks_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (e.NewValue == CheckState.Checked)
      {
        this.Stages = JsonSaveLoad.JsonLoadList(listView_List_Checks.Items[e.Index].Text);
        View_List_Stage();
      }
      else
      {
        if (listView_List_Checks.CheckedItems.Count - 1 == 0)
        {
          this.Stages = new List<Stages>();
          this.SelectedTest = new TestModel();
          View_List_Stage();
        }
        if (listView_List_Checks.CheckedItems.Count - 1 > 0)
        {
          this.Stages = JsonSaveLoad.JsonLoadList(listView_List_Checks.Items[e.Index - 1].Text);
          this.SelectedTest = new TestModel();
          View_List_Stage();
        }
      }
    }

    /// <summary>
    /// ��� �� ��� �� ��������� 
    /// �� ������ ������� ������ �������� ���������� � ��������� �����.
    /// </summary>
    private void ViewSelectedStage()
    {
      if (ListView_List_Stage.CheckedItems.Count >= 0)
      {
        tableLayoutPanel1.Visible = true;
        if (this.SelectedTest != null && !string.IsNullOrEmpty(this.SelectedTest.NameStage))
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
              textbox_Heart_Rate_Control.Text = $"{test.CHSS}";
            }
            if (test.ControlPneumogram)
            {
              checkBox_Pneumogram.Checked = true;
              comboBox_del_R.SelectedIndex = (int)EnumWorcker.GetIndexEnum_dR(test.dR);
              comboBox_Omega_R.SelectedIndex = (int)EnumWorcker.GetIndexEnum_wR(test.wR);
            }
            label_Text_Name_ECG.Text = ReturnNameECGFile(test);
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
      }
    }

    /// <summary>
    /// ��������� � ������ �� ����� ����������� ��������� ���� � ���������� ��� ��������. 
    /// </summary>
    /// <param name="test">����.</param>
    /// <returns>�������� �����.</returns>
    /// <exception cref="ArgumentException">�� ������������ ��� �����.</exception>
    /// <exception cref="ArgumentNullException">���� ����.</exception>
    public string ReturnNameECGFile(TestModel test)
    {
      if (test != null)
      {
        switch (test.stagesType)
        {
          case EnumStagesType.TestModel_CTSCSE:
            var ctscse = test as TestModel_CTSCSE;
            return $"{EnumWorcker.GetDescription(ctscse.Database)} {EnumWorcker.GetDescription(ctscse.Noise)}";
          case EnumStagesType.TestModel_ECG_Header:
            var ecg = test as TestModel_ECG_Header;
            return $"{ecg.HEADER.RecordName}";
          case EnumStagesType.TestModel_WaveForm:
            var wave = test as TestModel_WaveForm;
            return EnumWorcker.GetDescription(wave.Type);
          default:
            throw new ArgumentException("����������� ��� �����!");
        }
      }
      else
        throw new ArgumentNullException("test is null");
    }

    /// <summary>
    /// ��� ����� ������� ����� � ����� ������.
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
      {
        ListView_List_Stage.Clear();
        MessageBox.Show("������ ������ ����.");
      }
    }

    /// <summary>
    /// ���������� ������, � ���� ��� ���������� � ���������� ListViewItem �� ��������.
    /// </summary>
    /// <param name="list">������.</param>
    /// <param name="view">������ ��� ������.</param>
    /// <returns>True, ���� ���������� �������, ����� false/</returns>
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

    /// <summary>
    /// ��������� ������ �������� ��������� �� ����� txt ������. 
    /// </summary>
    private void SearchDBTXTFile()
    {
      foreach (var str in DBChecksMeneger.LoadNameTXTFile())
      {
        listView_List_Checks.Items.Add(str);
      }
    }

    #endregion

    #region ������ ��� �������� � ������ �����

    /// <summary>
    /// �������� ��������� �� �� ������������� ����� ECG. ��� �������.
    /// </summary>
    /// <param name="Database">���� ������ CTSCSE</param>
    /// <param name="noise">������ �����.</param>
    private void LoadDatabaseCTS_CSE(Enum_CTSCSE_Database database, Enum_CTSCSE_Noise noise)
    {
      try
      {
        this.SelectedTest = new TestModel();
        //database ��� � ����� ����������� � ���� (int) ������ �� �� ���� ���� �������� ��� database ����������� � ���
        //this.MECG20.LoadDatabaseCTS_CSE(database, noise);
        var test = new TestModel_CTSCSE() { Database = database, Noise = noise };
        this.SelectedTest = test;
        label_Text_Name_ECG.Text = ReturnNameECGFile(test);
        //MECG20.Output_waveform(0);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    /// <summary>
    /// �������� ��� �� ����������� ���� � �����. ��� �������.
    /// </summary>
    /// <param name="filepath">���� � �����.</param>
    private void LoadECG_FromFile(string filepath)
    {
      try
      {
        this.SelectedTest = new TestModel();
        if (!string.IsNullOrEmpty(filepath))
        {
          this.MECG20.Save_header(filepath);
          var test = new TestModel_ECG_Header() { HEADER = this.MECG20.Header };
          this.SelectedTest = test;
          label_Text_Name_ECG.Text = ReturnNameECGFile(test);
        }
        else
          throw new ArgumentException("���� ��� ������� �� ���������.");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    /// <summary>
    /// ��������� �������� ��� � ������� ������� �����.
    /// </summary>
    /// <param name="waveForm"></param>
    /// <param name="freaquency"></param>
    /// <param name="amplitude"></param>
    private void LoadECG_WaveForm(Enum_WAVEFORM_TYPE waveForm, double freaquency, double amplitude)
    {
      try
      {
        this.SelectedTest = new TestModel();
        var test = new TestModel_WaveForm() { Type = waveForm, Frequency = freaquency, Amplitude = amplitude };
        this.SelectedTest = test;
        label_Text_Name_ECG.Text = ReturnNameECGFile(test);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    #endregion

    #endregion

    #region �����������

    public MainForm()
    {
      InitializeComponent();
    }

    #endregion

  }
}
