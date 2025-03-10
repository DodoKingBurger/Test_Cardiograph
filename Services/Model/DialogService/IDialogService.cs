using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cardiograph.Services.Model
{
  /// <summary>
  /// Вначале добавим в него новый интерфейс IDialogService, который будет определять функционал для работы с диалоговыми окнами:
  /// </summary>
  public interface IDialogService
  {
    void ShowMessage(string message);   // показ сообщения
    string FilePath { get; set; }   // путь к выбранному файлу
    bool OpenFileDialog();  // открытие файла
    bool SaveFileDialog();  // сохранение файла
  }
}
