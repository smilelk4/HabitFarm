namespace HabitFarm;



public class Screen
{
    // constructor
    public Screen()
    {
        Console.WriteLine("Hello Habit Farm!");
        TextCopy.WriteIntro();
        
        var confirmedSelection = "";
        while (confirmedSelection != MenuOptions.QUIT)
        {
            Console.Clear();
            TextCopy.WriteIntro();
            Menu.RenderMenu();
            confirmedSelection = Menu.HandleInput();

            if (confirmedSelection == MenuOptions.CREATE_HABIT)
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