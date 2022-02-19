namespace HabitFarm;

public class TextCopy
{
  public static string inputIndicator = " > ";

  public static string title = @"
 _    _       _     _ _     ______                   
| |  | |     | |   (_) |   |  ____|                  
| |__| | __ _| |__  _| |_  | |__ __ _ _ __ _ __ ___  
|  __  |/ _` | '_ \| | __| |  __/ _` | '__| '_ ` _ \ 
| |  | | (_| | |_) | | |_  | | | (_| | |  | | | | | |
|_|  |_|\__,_|_.__/|_|\__| |_|  \__,_|_|  |_| |_| |_|
";
  public static string credits = @"                by
      Yuka Moribe & Alicia Kim";
  public static string jam = "      for 'Regenerate Game Jam' (Feb 2022)";
  public static string introduction = "\n\n\nWelcome to Habit Farm, where you can grow healthy habits. Choose a plant for each habit, water them whenever you succeed, and watch your plants grow little by little.";
  public static string promptName = $"\nWhat is your name? {inputIndicator}";
  
  // property
  public static string? PlayerName { get; set;  }
  
  public static void WriteIntro()
  {
    Console.WriteLine(title);
    Console.WriteLine(credits);
    Console.WriteLine(jam);
    Console.WriteLine(introduction);
  }

  public static void PromptForName()
  {
    Console.WriteLine(promptName);
    PlayerName = Console.ReadLine();
    Console.WriteLine($"\nNice to meet you, {PlayerName}!");
  }
}