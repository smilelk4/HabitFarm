namespace HabitFarm;

enum ValidKey
{
    Q = 81,
    Enter = 13,
    LeftArrow = 37,
    RightArrow = 39,
};

public static class Menu
{
    private static int selectedOption = 0;
    private static string[] menuOptions = {"Create Habit (C)", "Habits (H)", "Seeds (S)", "Quit (Q)", };
    
    public static void RenderSelectedOption()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write($" 🌼 {menuOptions[selectedOption]} ");
        Console.ResetColor();
    }
    
    public static void RenderMenu()
    {
        Console.WriteLine("\n *****");
        for (int index = 0; index < menuOptions.Length; index++)
        {
            if (index == selectedOption)
            {
                RenderSelectedOption();
            }
            else
            {
                Console.Write($" 🌱 {menuOptions[index]} ");
            }
        }
    }

    public static string GetSelectedOption()
    {
        return menuOptions[selectedOption];
    }

    public static ConsoleKey? ListenForKey()
    {
        var key = Console.ReadKey(true).Key;
        Console.Beep();
        bool isKeyValid = Enum.IsDefined(typeof(ValidKey), (ValidKey) key);
        if (!isKeyValid) 
        {
            return null;
        }
        return key;
    }

    public static bool PlayerPressedKey(string pressedKey, string keyToCheck)
    {
        return pressedKey == keyToCheck;
    }

    public static string HandleInput()
    {
        var key = ListenForKey();
        if (key == null) return "";
            
        switch (key)
        {
            case ConsoleKey.LeftArrow:
            {
                if (selectedOption == 0)
                {
                    selectedOption = menuOptions.Length - 1;
                } else
                {
                    selectedOption--;
                }

                break;
            }
            case ConsoleKey.RightArrow:
            {
                if (selectedOption < menuOptions.Length - 1)
                {
                    selectedOption++;
                } else
                {
                    selectedOption = 0;
                }

                break;
            }

            case ConsoleKey.Q:
            {
                return "Quit";
            }

            case ConsoleKey.Enter:
            {
                return menuOptions[selectedOption];
            }
        }

        return "";
    }
}