using System;
using Newtonsoft.Json;
using Test_Cardiograph.Services.Model.Stages;

namespace D_DCharLists
{
	/// <summary>
	/// Класс для сохранения и загрузки в БД.
	/// </summary>
	public class JsonSaveLoad
	{
		/// <summary>
		/// Сохранить в формате .json
		/// </summary>
		/// <typeparam name="T">Какого типа будет передаваться сохраняймый файл.</typeparam>
		/// <param name="fileName">Название файла.</param>
		/// <param name="savingFile">Сохраняймый файл.</param>
		/// <param name="pathSave">Путь где будет соранен файл.</param>
		public static void JsonSave<T>(string fileName, T savingFile, string pathSave)
		{
			string savedFile = JsonConvert.SerializeObject(savingFile, Formatting.Indented);
			File.WriteAllText($"{pathSave}\\{fileName}.json", savedFile);
		}

		/// <summary>
		/// Загрузить файл формата .json
		/// </summary>
		/// <typeparam name="T">Загружаймый класс.</typeparam>
		/// <param name="pathLoad">Путь для загрузки.</param>
		/// <param name="sheet">Куда будут загружены данные.</param>
		public static void JsonLoad(string pathLoad, ref Stages sheet)
		{
      using (StreamReader streamReader = new StreamReader("example.json"))
      {
        string json = streamReader.ReadToEnd();
        sheet = JsonConvert.DeserializeObject<Stages>(json);
      }

    }
	}

  //public static class JsonHelpers
  //{
  //  public static T CreateFromJsonStream<T>(this Stream stream)
  //  {
  //    JsonSerializer serializer = new JsonSerializer();
  //    T data;
  //    using (StreamReader streamReader = new StreamReader(stream))
  //    {
  //      data = (T)serializer.Deserialize(streamReader, typeof(T));
  //    }
  //    return data;
  //  }

  //  public static T CreateFromJsonString<T>(this String json)
  //  {
  //    T data;
  //    using (MemoryStream stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json)))
  //    {
  //      data = CreateFromJsonStream<T>(stream);
  //    }
  //    return data;
  //  }

  //  public static T CreateFromJsonFile<T>(this String fileName)
  //  {
  //    T data;
  //    using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
  //    {
  //      data = CreateFromJsonStream<T>(fileStream);
  //    }
  //    return data;
  //  }
  //}
}
