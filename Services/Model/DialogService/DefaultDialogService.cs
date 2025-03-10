using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows;


namespace Test_Cardiograph.Services.Model
{
  public class DefaultDialogService : IDialogService
  {
    public string FilePath { get; set; }

    public bool OpenFileDialog()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.ShowDialog();
      FilePath = openFileDialog.FileName;
      return true;
    }

    public bool SaveFileDialog()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.ShowDialog();
      FilePath = saveFileDialog.FileName;
      return true;
    }

    public void ShowMessage(string message)
    {
      MessageBox.Show(message);
    }
  }
}
