namespace HabitFarm;

public class HabitCreator
{
  // property
  public static string HabitTitle { get; set; }

  // constructor
  public HabitCreator()

  {
    Console.WriteLine("\n\nWhat is your habit? ");
    Console.Write(" >>> ");
    HabitTitle = Console.ReadLine();
    SaveHabit();
    Console.WriteLine($"\nHabit {HabitTitle} saved! (Press Enter to continue)");
    
  }

  public static void SaveHabit()
  {
    if (HabitTitle != null) {
      SaveSystem.AppendToSaveDataProperty("Habits", HabitTitle);
    }
  }

  
  // prompt user for habit name
  // save
  // p1 select seed
  // p1 cancel
}
