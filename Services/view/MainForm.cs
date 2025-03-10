using System.Windows.Forms;
using Test_Cardiograph.Controller;
using Test_Cardiograph.Properties.DB;
using Test_Cardiograph.Services.Controller.MECG.structs;
using Test_Cardiograph.Services.Model.Stages;
using Test_Cardiograph.Services.Model.Stages.descendant.Command.descendant;
using Test_Cardiograph.Services.Model.Stages.descendant.Test;
using Test_Cardiograph.Services.StaticClass;
using Test_Cardiograph.Services.view;
using static System.Net.Mime.MediaTypeNames;
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
    public List<TestModel> Stages;

    public Dictionary<string, List<TestModel>> Checks;

    /// <summary>
    /// ��������� ���� ��� ��������������.
    /// </summary>
    public TestModel SelectedTest;

    /// <summary>
    /// ������ ���������� ���������� �����.
    /// </summary>
    private int Cursore = 0;

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
      numericUpDown_Heart_Rate_Control.Enabled = false;
      tableLayoutPanel_Pneumogram.Enabled = false;
      comboBox_Type_Command_View.Items.AddRange(Enum.GetValues(typeof(EnumOptionsStages))
        .OfType<EnumOptionsStages>().Select(val => EnumWorcker.GetDescription(val)).ToArray());
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

    /// <summary>
    /// ������ ��� ���������� ���������� ����� � ������ ������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="Exception"></exception>
    private void button_Save_Selected_Stage_Click(object sender, EventArgs e)
    {
      //���� �������� ������, ���� ��� �� ������.
      switch (EnumWorcker.EnumValueOf(comboBox_Type_Command_View.SelectedItem.ToString(), typeof(EnumOptionsStages)))
      {
        case EnumOptionsStages.Command:
          this.SelectedTest.NameTest = textBox_Name_Stage.Text;
          this.SelectedTest.ControlCHSS = checkBox_Heart_Rate_Control.Checked;
          if (this.SelectedTest.ControlCHSS)
            this.SelectedTest.CHSS = ((int)numericUpDown_Heart_Rate_Control.Value);
          this.SelectedTest.ControlPneumogram = checkBox_Pneumogram.Checked;
          if (this.SelectedTest.ControlPneumogram)
          {
            //� ����������, ���� ������ ��������� �������� ���� ��� ��������� ���������.
            this.SelectedTest.dR = (int)comboBox_del_R.SelectedItem;
            this.SelectedTest.wR = (int)comboBox_Omega_R.SelectedItem;
          }
          break;
        case EnumOptionsStages.Notifications:

          break;

        case EnumOptionsStages.NotificationsConfirmation:

          break;
        default:
          throw new Exception("�������� ��� �����");
      }
      if (!this.Stages.Contains(SelectedTest))
      {
        this.Stages.Insert(0, SelectedTest);
      }
      else
        MessageBox.Show("����� ���� ��� ����������.");
    }

    #region ���������� ��������� ����� 

    /// <summary>
    /// ����� �� ����������� ���.
    /// </summary>
    /// <param name="sender">��� ����.</param>
    /// <param name="e">��������� ��������� ��� �����.</param>
    private void checkBox_Heart_Rate_Control_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox_Heart_Rate_Control.Checked)
        numericUpDown_Heart_Rate_Control.Enabled = true;
      else
        numericUpDown_Heart_Rate_Control.Enabled = false;
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
          this.Stages.Remove(this.SelectedTest);
          this.Stages.Insert(this.Cursore - 1, this.SelectedTest);
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
          this.Stages.Remove(this.SelectedTest);
          if(this.Cursore +1 < this.Stages.Count)
            this.Stages.Insert(this.Cursore + 1, this.SelectedTest);
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
    private void checkedListBox_List_Stage_SelectedIndexChanged(object sender, EventArgs e)
    {
      string strGetLastItem = string.Empty;

      foreach (object item in checkedListBox_List_Stage.CheckedItems)
      {
        strGetLastItem = (string)item;
      }

      this.Cursore = checkedListBox_List_Stage.Items.IndexOf(strGetLastItem);

      this.SelectedTest = this.Stages[this.Cursore];
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
        this.SelectedTest = new TestModel_CTSCSE() { Database = database, Noise = noise };
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
          this.SelectedTest = new TestModel_ECG_Header() { HEADER = this.MECG20.Header };
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
        this.SelectedTest = new TestModel_WaveForm() { Type = waveForm, Frequency = freaquency, Amplitude = amplitude };
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
