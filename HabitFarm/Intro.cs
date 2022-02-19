namespace HabitFarm;

enum TimeOfDay
{
  Morning,
  Afternoon,
  Evening,
  Night
}

public class TextCopy
{
  // fields
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

  // properties
  public static string? PlayerName { get; private set; }

  //  methods
  public static void WriteIntro()
  {
    Console.WriteLine(title);
    Console.WriteLine(credits);
    Console.WriteLine(jam);

    if (SaveData.GetIfFileExists())
    {
      PlayerName = SaveData.GetSaveData()?.PlayerName;
      GreetByTimeOfDay();
      // Console.WriteLine($"{}, sweet, sweet, {PlayerName}. :) :) :D");
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

  private static void GreetByTimeOfDay()
  {
    DateTime currentDateTime = DateTime.Now;

  // Ways to build a dictionary
  // 1. 
  Dictionary<TimeOfDay, Dictionary<string, object>> greetingsConfig = new Dictionary<TimeOfDay, Dictionary<string, object>>()
    {
      { TimeOfDay.Morning, new Dictionary<string,object>()
        {
          {"Greeting", "Good morning"},
          {"TimeStart", new TimeSpan(5, 0, 0)},
        }
      },
      { TimeOfDay.Afternoon, new Dictionary<string,object>()
        {
          {"Greeting", "Good afternoon"},
          {"TimeStart", new TimeSpan(12, 0, 0)},
        }
      },
      { TimeOfDay.Evening, new Dictionary<string,object>()
        {
          {"Greeting", "Good evening"},
          {"TimeStart", new TimeSpan(18, 0, 0)},
        }
      },
      { TimeOfDay.Night, new Dictionary<string, object>()
        {
          {"Greeting", "Good night"},
          {"TimeStart", new TimeSpan(21, 0, 0)},
        }
      },
    };

    // // 2. 
    // var Greetings2 = new Dictionary<string, string>();
    // Greetings2["Morning"] = "Good morning";
    // Greetings2["Afternoon"] = "Good afternoon";
    // Greetings2["Evening"] = "Good evening";
    // Greetings2["Night"] = "Good night";

    // // 3.
    // var greetings3 = new Dictionary<string, string>();
    // greetings3.Add("morning", "Good morning");
    // greetings3.Add("afternoon", "Good afternoon");
    // greetings3.Add("evening", "Good evening");
    // greetings3.Add("night", "Good night");

    if (currentDateTime.TimeOfDay > (TimeSpan)greetingsConfig[TimeOfDay.Morning]["TimeStart"])
    {
      Console.WriteLine($"\n\n{greetingsConfig[TimeOfDay.Morning]["Greeting"]}, sweet, beautiful, genius {PlayerName}!");
      Console.WriteLine($"Today is {currentDateTime.ToLongDateString() }. The time is {currentDateTime.ToShortTimeString() }.");
    }
  }
}

