using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Test_Cardiograph.Services.Model.Stages;
using Test_Cardiograph.Services.Model.Stages.descendant.Notifications;
using Test_Cardiograph.Services.Model.Stages.descendant.Notifications_confirmation;
using Test_Cardiograph.Services.Model.Stages.descendant.Test;

namespace Test_Cardiograph.Services.JsonSaveLoad
{
  class StageItemConvecter : JsonConverter<Stages>
{
    public override Stages Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
      var jsonObject = JsonDocument.ParseValue(ref reader).RootElement;

      if (jsonObject.TryGetProperty("Type", out var typeProperty))
      {
        var type = typeProperty.GetString();

        if (type == nameof(TestModel))
        {
          return JsonSerializer.Deserialize<TestModel>(jsonObject.GetRawText(), options)!;
        }
        else if (type == nameof(Stage_Notifications))
        {
          return JsonSerializer.Deserialize<Stage_Notifications>(jsonObject.GetRawText(), options)!;
        }
        else if (type == nameof(Stage_Notifications_Confirmation))
        {
          return JsonSerializer.Deserialize<Stage_Notifications_Confirmation>(jsonObject.GetRawText(), options)!;
        }

      }

      throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, Stages value, JsonSerializerOptions options)
    {
      JsonSerializer.Serialize(writer, (dynamic)value, options);
    }
  }
}
