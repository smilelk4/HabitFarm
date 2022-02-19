using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HabitFarm;

public record SaveDataRecord(
    string PlayerName,
    DateTime CreatedAt,
    DateTime UpdatedAt
);

public class SaveData
{
    private static string _fileName = "saveData.txt";

    public static void CreateSaveData(string playerName)
    {
        SaveDataRecord newSaveData = new SaveDataRecord(PlayerName:playerName, CreatedAt: DateTime.Now, UpdatedAt: DateTime.Now);
        string saveDataJson = JsonSerializer.Serialize(newSaveData);
        Console.WriteLine(saveDataJson);
        Console.WriteLine(Path.GetFullPath("."));
        File.WriteAllText(_fileName, saveDataJson);
        GetSaveData();
    }

    public static void GetSaveData()
    {
        var savedDataJson = File.ReadAllText(_fileName);
        var saveData = JsonSerializer.Deserialize<SaveDataRecord>(savedDataJson);
        Console.WriteLine(saveData.PlayerName);
    }
}