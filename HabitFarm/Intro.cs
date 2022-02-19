namespace HabitFarm;

public class PartOfDay
{
  // fields
  public string? _greeting;
  public TimeSpan _timeStart;
  public bool _isCurrentTime;

  // constructor
  public PartOfDay(string greeting, TimeSpan timeStart, bool isCurrentTime = false) // default value
  {
    _greeting = greeting;
    _timeStart = timeStart;
    _isCurrentTime = isCurrentTime;
  }
};

public class TextCopy
{
  // fields
  private static string inputIndicator = "\n >>> ";

  private static string title = @"
 _    _       _     _ _     ______                   
| |  | |     | |   (_) |   |  ____|                  
| |__| | __ _| |__  _| |_  | |__ __ _ _ __ _ __ ___  
|  __  |/ _` | '_ \| | __| |  __/ _` | '__| '_ ` _ \ 
| |  | | (_| | |_) | | |_  | | | (_| | |  | | | | | |
|_|  |_|\__,_|_.__/|_|\__| |_|  \__,_|_|  |_| |_| |_|
";
  private static string credits = @"                    by
            Yuka Moribe & Alicia Kim";
  private static string jam = "      for 'Regenerate Game Jam' (Feb 2022)";
  private static string introduction = "\n\n\nWelcome to Habit Farm, where you can grow healthy habits. Choose a plant for each habit, water them whenever you succeed, and watch your plants grow little by little.";
  private static string promptName = $"\nWhat is your name? {inputIndicator}";

  // properties
  private static string? PlayerName { get; set; }

  //  methods
  public static void WriteIntro()
  {
    Console.WriteLine(title);
    Console.WriteLine(credits);
    Console.WriteLine(jam);

    if (SaveSystem.GetIfFileExists())
    {
      PlayerName = SaveSystem.GetSaveData()?.PlayerName;
      GreetByTimeOfDay();
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
    SaveSystem.CreateSaveData(PlayerName);
  }

  private static void GreetByTimeOfDay()
  {
    DateTime currentDateTime = DateTime.Now;
    TimeSpan currentTime = currentDateTime.TimeOfDay;

    PartOfDay morning = new PartOfDay(
      "Good morning", new TimeSpan(5, 0, 0)
    );

    PartOfDay afternoon = new PartOfDay(
     "Good afternoon", new TimeSpan(12, 0, 0)
    );

    PartOfDay evening = new PartOfDay(
       "Good evening", new TimeSpan(18, 0, 0)
    );

    PartOfDay night = new PartOfDay(
       "Good night", new TimeSpan(21, 0, 0)
    );

    morning._isCurrentTime = currentTime >= morning._timeStart && currentTime < afternoon._timeStart;
    afternoon._isCurrentTime = currentTime >= afternoon._timeStart && currentTime < evening._timeStart;
    evening._isCurrentTime = currentTime >= evening._timeStart && currentTime < night._timeStart;
    night._isCurrentTime = currentTime >= night._timeStart && currentTime < night._timeStart;

    PartOfDay[] partsOfDay = { morning, afternoon, evening, night };

    string? greeting = "";

    foreach (PartOfDay partOfDay in partsOfDay)
    {
      if (partOfDay._isCurrentTime)
      {
        greeting = partOfDay._greeting;
      }
    }

    Console.WriteLine($"\n\n{greeting}, sweet, beautiful, genius {PlayerName}!");
    Console.WriteLine($"Today is {currentDateTime.ToLongDateString() }. The time is {currentDateTime.ToShortTimeString() }.");
  }
}