using Test_Cardiograph.Services.view;

namespace Test_Cardiograph
{
  public partial class MainForm : Form
  {
    #region Поля и свойства

    /// <summary>
    /// Форма с базой данных прибора MECG20
    /// </summary>
    private DB_CTSCSE_DB cTSCSE_DB { get; set; }

    #endregion

    #region Методы

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void button_Sum_CTSCSEDB_Click(object sender, EventArgs e)
    {
      cTSCSE_DB = new DB_CTSCSE_DB();
      cTSCSE_DB.ShowDialog();
    }

    #endregion

    #region Конструктор
    
    public MainForm()
    {
      InitializeComponent();
    }

    #endregion
  }
}
