namespace HabitFarm;

public class TextCopy
{
  private static string inputIndicator = " > ";

  private static string title = @"
 _    _       _     _ _     ______                   
| |  | |     | |   (_) |   |  ____|                  
| |__| | __ _| |__  _| |_  | |__ __ _ _ __ _ __ ___  
|  __  |/ _` | '_ \| | __| |  __/ _` | '__| '_ ` _ \ 
| |  | | (_| | |_) | | |_  | | | (_| | |  | | | | | |
|_|  |_|\__,_|_.__/|_|\__| |_|  \__,_|_|  |_| |_| |_|
";
  private static string credits = @"                by
      Yuka Moribe & Alicia Kim";
  private static string jam = "      for 'Regenerate Game Jam' (Feb 2022)";
  private static string introduction = "\n\n\nWelcome to Habit Farm, where you can grow healthy habits. Choose a plant for each habit, water them whenever you succeed, and watch your plants grow little by little.";
  private static string promptName = $"\nWhat is your name? {inputIndicator}";
  
  // property
  public static string? PlayerName { get; private set;  }
  
  public static void WriteIntro()
  {
    Console.WriteLine(title);
    Console.WriteLine(credits);
    Console.WriteLine(jam);

    if (SaveData.GetIfFileExists())
    {
      PlayerName = SaveData.GetSaveData()?.PlayerName;
      Console.WriteLine($"Welcome back, sweet, sweet, {PlayerName}. :) :) :D");
    }
    else
    {
      Console.WriteLine(introduction);
      SavePlayerName();
      Console.WriteLine($"\nNice to meet you, {PlayerName}! Created a new save file.");
    }
  }

  private static void SavePlayerName()
  {
    Console.WriteLine(promptName);
    PlayerName = Console.ReadLine();
    SaveData.CreateSaveData(PlayerName);
  }
}