using System;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using Test_Cardiograph.Services.Model.Stages;
using Test_Cardiograph.Services.Model.Stages.descendant.Command.descendant;
using Test_Cardiograph.Services.Model.Stages.descendant.Notifications;
using Test_Cardiograph.Services.Model.Stages.descendant.Notifications_confirmation;
using Test_Cardiograph.Services.Model.Stages.descendant.Test;

namespace D_DCharLists
{
	/// <summary>
	/// Класс для сохранения и загрузки в БД.
	/// </summary>
	public static class JsonSaveLoad
	{
    /// <summary>
    /// Путь к папке с БД. Просто подставь название папки;
    /// </summary>
    private static string pathFolderChecks = string.Join("\\", Environment.CurrentDirectory.Split('\\'), 0, Environment.CurrentDirectory.Split('\\').Length - 3) + $"\\Properties\\Checks";

    /// <summary>
    /// Сохранить в формате .json
    /// </summary>
    /// <typeparam name="T">Какого типа будет передаваться сохраняймый файл.</typeparam>
    /// <param name="fileName">Название файла.</param>
    /// <param name="savingFile">Сохраняймый файл.</param>
    /// <param name="pathSave">Путь где будет соранен файл.</param>
    public static void JsonSave<T>(string fileName, T savingFile, string pathSave)
		{
			var options = new JsonSerializerOptions
      {
        WriteIndented = true
      };
			string savedFile = JsonSerializer.Serialize<T>(savingFile, options);
			File.WriteAllText($"{pathSave}\\{fileName}.json", savedFile);
		}

    /// <summary>
    /// Загрузить файл формата .json
    /// </summary>
    /// <typeparam name="T">Загружаймый класс.</typeparam>
    /// <param name="pathLoad">Путь для загрузки.</param>
    /// <param name="sheet">Куда будут загружены данные.</param>
    public static Stages JsonLoad(string pathLoad)
    {
      using (StreamReader streamReader = new StreamReader(pathLoad))
      {
        string json = streamReader.ReadToEnd();
        // В Stages хранится список возможных этапов и при получении Stages я могу понять какой тип будет у обьекта внутри по настоящему.
        Stages sheets = JsonSerializer.Deserialize<Stages>(json);
        switch (sheets.stagesType)
        {
          case EnumStagesType.TestModel_CTSCSE:
            return JsonSerializer.Deserialize<TestModel_CTSCSE>(json);
          case EnumStagesType.TestModel_ECG_Header:
            return JsonSerializer.Deserialize<TestModel_ECG_Header>(json);
          case EnumStagesType.TestModel_WaveForm:
            return JsonSerializer.Deserialize<TestModel_WaveForm>(json);
          case EnumStagesType.Notifications:
            return JsonSerializer.Deserialize<Stage_Notifications>(json);
          case EnumStagesType.Notifications_Confirmation:
            return JsonSerializer.Deserialize<Stage_Notifications_Confirmation>(json);
          default:
            throw new JsonException("Неизвестный тип этапа.");
        }
      }
    }


    /// <summary>
    /// Загрузить файл формата .json
    /// </summary>
    /// <typeparam name="T">Загружаймый класс.</typeparam>
    /// <param name="pathLoad">Путь для загрузки.</param>
    /// <param name="sheet">Куда будут загружены данные.</param>
    public static List<Stages> JsonLoadList(string NameFileDB)
    {
      List<Stages> lsit = new List<Stages>();
      //В обычном блокноте символ новой строки \n\r пришлось создавать файл вручную, иначе бы он дробил текст с пустыми строками.
      string[] strings = File.ReadAllText(pathFolderChecks + $"\\{NameFileDB}").Split(new char[] { '\n', '\r' });
      foreach (var str in strings)
      {
        if (!string.IsNullOrEmpty(str))
        {
          if (File.Exists(pathFolderChecks + $"\\Stage\\{str}"))
            lsit.Add(JsonLoad(pathFolderChecks + $"\\Stage\\{str}"));
        }
      }
      return lsit;
    }

    ///// <summary>
    ///// Загрузить файл формата .json
    ///// </summary>
    ///// <typeparam name="T">Загружаймый класс.</typeparam>
    ///// <param name="pathLoad">Путь для загрузки.</param>
    ///// <param name="sheet">Куда будут загружены данные.</param>
    //public static void JsonLoad<T>(string pathLoad, ref T sheet)
    //{
    //    using (StreamReader streamReader = new StreamReader(pathLoad))
    //    {
    //      string json = streamReader.ReadToEnd();
    //      sheet = JsonSerializer.Deserialize<T>(json); 
    //    }
    //  }
  }

}
