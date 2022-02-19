namespace HabitFarm;

public class HabitCreator
{
  // property
  public static string HabitTitle { get; set; }

  // constructor
  public HabitCreator()

  {
    Console.WriteLine("What is your habit? ");
    Console.WriteLine(" >>> ");
    HabitTitle = Console.ReadLine();
    SaveHabit();
  }

  public static void SaveHabit()
  {
    if (HabitTitle != null) {
      SaveSystem.AppendToSaveDataProperty("Habits", HabitTitle);
      Console.WriteLine(SaveSystem.GetSaveData());
    }
  }

  
  // prompt user for habit name
  // save
  // p1 select seed
  // p1 cancel
}
