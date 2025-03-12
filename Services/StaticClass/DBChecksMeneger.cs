using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Test_Cardiograph.Services.StaticClass
{
  class DBChecksMeneger
  {

    /// <summary>
    /// Загрузка БД из папки РОХМиНЭ.
    /// </summary>
    /// <returns>Названия БД.</returns>
    public static string[] LoadNameTXTFile()
    {
      List<string> FileName = new List<string>();
      foreach (var str in Directory.GetFiles(string.Join("\\", Environment.CurrentDirectory.Split('\\'), 0, Environment.CurrentDirectory.Split('\\').Length - 3) + $"\\Properties\\Checks", "*.txt"))
      {
        FileName.Add(str.Split('\\').Last());
      }
      return FileName.ToArray();
    }
  }
}
