using System.Text.Json;

namespace HabitFarm;

// public record SaveDataRecord(
//     string PlayerName,
//     DateTime CreatedAt,
//     DateTime UpdatedAt,
//     string[]? Habits = null
// );

public static class SaveSystem
{
    public static string PlayerName { get; set; }
  public static DateTime CreatedAt { get; set; }
  public static DateTime UpdatedAt { get; set; }
  public static string[]? Habits { get; set; }


    private static string _fileName = "saveData.json";

    public static void CreateSaveData()
    {
    // TIP how to get current path
    // Console.WriteLine(Path.GetFullPath("."));

    var newSaveData = new Dictionary<string, dynamic>()
        {
            { "PlayerName", TextCopy.PlayerName },
            { "CreatedAt", DateTime.Now },
            { "UpdatedAt", DateTime.Now },
            { "Habits", new List<string>() }
        };
        string saveDataJson = JsonSerializer.Serialize(newSaveData);
        File.WriteAllText(_fileName, saveDataJson);
    }

    public static void UpdateSaveDataProperty(string property, object value)
    {
        var saveData = GetSaveData();
        saveData[property] = value;
        string saveDataJson = JsonSerializer.Serialize(saveData);
        File.WriteAllText(_fileName, saveDataJson);
    }

    public static void AppendToSaveDataProperty(string property, dynamic value)
    {
        var saveData = GetSaveData();
        List<dynamic> values = JsonSerializer.Deserialize<List<dynamic>>(saveData[property]);
        values.Add(value);
        saveData[property] = values;

    string saveDataJson = JsonSerializer.Serialize(saveData);
        File.WriteAllText(_fileName, saveDataJson);
    }

    public static Dictionary<string, dynamic>? GetSaveData()
    {
        var savedDataJson = File.ReadAllText(_fileName);
        var saveData = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(savedDataJson);
        return saveData;
    }

    public static bool GetIfFileExists()
    {
        return File.Exists(_fileName);
    }
}

        // Try sometime: https://stackoverflow.com/questions/16019729/deserializing-json-object-into-a-c-sharp-list
        //This works
        // var deserializedItemsFromItems = JsonConvert.DeserializeObject<List<Item>>(itemsSerialized);