using System.IO;

namespace HabitFarm;

public record SaveDataRecord(
    string PlayerName,
    DateTime CreatedAt,
    DateTime UpdatedAt
);

public class SaveData
{
    private string _fileName = "saveData.txt";

    public static void CreateSaveData(string playerName)
    {
        SaveDataRecord newSaveData = new SaveDataRecord(PlayerName:playerName, CreatedAt: DateTime.Now, UpdatedAt: DateTime.Now);
        Console.WriteLine(newSaveData);
        // File.WriteAllText(_fileName, );
    }
}