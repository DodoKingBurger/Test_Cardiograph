using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Cardiograph.Services.Controller.MECG.structs;

namespace Test_Cardiograph.Services.view
{
  public partial class DB_CTSCSE_DB : Form
  {
    #region Методы

    private void DB_CTSCSE_DB_Load(object sender, EventArgs e)
    {
      checkedListBox_DB_Noise.DataSource = Enum.GetNames(typeof(CTSCSE_Noise));
      checkedListBox_CTS_Atlas.DataSource = Enum.GetNames(typeof(CTSCSE_Database)).Take(19).ToArray<string>();
      checkedListBox_CSE.DataSource = Enum.GetNames(typeof(CTSCSE_Database)).Skip(19).ToArray<string>();
    }

    #endregion

    #region Констуркторы

    public DB_CTSCSE_DB()
    {
      InitializeComponent();
    }

    #endregion

  }
}
