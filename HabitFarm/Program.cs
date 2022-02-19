namespace HabitFarm;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello Habit Farm!");
        TextCopy.WriteIntro();
        TextCopy.PromptForName();
        SaveData.CreateSaveData(TextCopy.PlayerName);
    }
}