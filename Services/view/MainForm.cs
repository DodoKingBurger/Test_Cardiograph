using Test_Cardiograph.Controller;
using Test_Cardiograph.Services.Controller.MECG.structs;
using Test_Cardiograph.Services.Model;
using Test_Cardiograph.Services.view;

namespace Test_Cardiograph
{
  public partial class MainForm : Form
  {
    #region ���� � ��������

    /// <summary>
    /// ����� � ����� ������ ������� MECG20
    /// </summary>
    private DB_CTSCSE_DBForm cTSCSE_DB { get; set; }

    private MECG MECG20;

    /// <summary>
    /// ������ ������ � �������� �� ���������� �����.
    /// </summary>
    public List<TestModel> Tests = new List<TestModel>();

    /// <summary>
    /// ��������� ���� ��� ��������������.
    /// </summary>
    public TestModel SelectedTest;

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
    }

    /// <summary>
    /// ����� ����� ��� ������ �� �� ���.
    /// </summary>
    /// <param name="sender">������.</param>
    /// <param name="e">����.</param>
    private void button_Choice_ECG_Header_Click(object sender, EventArgs e)
    {
      cTSCSE_DB = new DB_CTSCSE_DBForm();
      cTSCSE_DB.LoadFileCTSCSE += LoadDatabaseCTS_CSE;
      cTSCSE_DB.ShowDialog();
    }

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

    #region ������ ��� �������� � ������ �����

    /// <summary>
    /// �������� ��������� �� �� ������������� ����� ECG.
    /// </summary>
    /// <param name="database">���� ������ CTSCSE</param>
    /// <param name="noise">������ �����.</param>
    private void LoadDatabaseCTS_CSE(CTSCSE_Database database, CTSCSE_Noise noise)
    {
      try
      {
        //database ��� � ����� ����������� � ���� (int) ������ �� �� ���� ���� �������� ��� database ����������� � ���
        MECG20.LoadDatabaseCTS_CSE(database, noise);
        MECG20.Output_waveform(0);
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
