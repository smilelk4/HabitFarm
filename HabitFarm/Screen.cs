namespace HabitFarm;

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
        Console.WriteLine(confirmedSelection);
    }
}