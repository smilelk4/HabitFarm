using System.Text.Json;

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
        // how to get current path
        // Console.WriteLine(Path.GetFullPath("."));
        File.WriteAllText(_fileName, saveDataJson);
        GetSaveData();
    }

    public static SaveDataRecord? GetSaveData()
    {
        var savedDataJson = File.ReadAllText(_fileName);
        var saveData = JsonSerializer.Deserialize<SaveDataRecord>(savedDataJson);
        return saveData;
    }

    public static bool GetIfFileExists()
    {
        return File.Exists(_fileName);
    }
}