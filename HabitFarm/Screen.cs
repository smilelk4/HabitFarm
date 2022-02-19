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
        while (confirmedSelection == "")
        {
            TextCopy.WriteIntro();
            Menu.RenderMenu();
            confirmedSelection = Menu.HandleInput();

        }

        if (confirmedSelection == "Create Habit")
        {
            Console.WriteLine("Making a habit!");
            new HabitCreator();
    } 
        Console.WriteLine(confirmedSelection);
    }
}