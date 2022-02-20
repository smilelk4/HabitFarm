namespace HabitFarm;

public class Constants
{
  public string CREATE_HABIT = "Create habit";
}

public class Screen
{
    // constructor
    public Screen()
    {
        Console.WriteLine("Hello Habit Farm!");
        TextCopy.WriteIntro();
        
        var confirmedSelection = "";
        while (confirmedSelection != "Quit")
        {
            Console.Clear();
            TextCopy.WriteIntro();
            Menu.RenderMenu();
            confirmedSelection = Menu.HandleInput();

            if (confirmedSelection == "Create Habit")
            {
                new HabitCreator();
                ConsoleKey? key = null;
                while (key != ConsoleKey.Enter)
                {
                    key = Menu.ListenForKey();
                }

            }
        }
    }
}