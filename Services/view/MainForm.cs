using Test_Cardiograph.Controller;
using Test_Cardiograph.Services.Controller.MECG.structs;
using Test_Cardiograph.Services.Model;
using Test_Cardiograph.Services.view;

namespace Test_Cardiograph
{
  public partial class MainForm : Form
  {
    #region Поля и свойства

    /// <summary>
    /// Форма с базой данных прибора MECG20
    /// </summary>
    private DB_CTSCSE_DBForm cTSCSE_DB { get; set; }

    private MECG MECG20;

    /// <summary>
    /// Список тестов и присущий им порядковый номер.
    /// </summary>
    public List<TestModel> Tests = new List<TestModel>();

    /// <summary>
    /// Выбранный тест для редактирования.
    /// </summary>
    public TestModel SelectedTest;

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
    }

    /// <summary>
    /// Вызов формы для выбора из БД ЭКГ.
    /// </summary>
    /// <param name="sender">Кнопка.</param>
    /// <param name="e">Клик.</param>
    private void button_Choice_ECG_Header_Click(object sender, EventArgs e)
    {
      cTSCSE_DB = new DB_CTSCSE_DBForm();
      cTSCSE_DB.LoadFileCTSCSE += LoadDatabaseCTS_CSE;
      cTSCSE_DB.ShowDialog();
    }

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

    #region Методы для отправки в другие формы

    /// <summary>
    /// Загрузка выбранной из БД заголовочного файла ECG.
    /// </summary>
    /// <param name="database">База данных CTSCSE</param>
    /// <param name="noise">Фильтр шумов.</param>
    private void LoadDatabaseCTS_CSE(CTSCSE_Database database, CTSCSE_Noise noise)
    {
      try
      {
        //database был с явным приведением к типу (int) почему то не дает явно передать что database конвертится в инт
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

    #region Конструктор

    public MainForm()
    {
      InitializeComponent();
    }

    #endregion
  }
}
