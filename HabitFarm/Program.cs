namespace HabitFarm;

class Program
{
    private static string title = "Habit Farm";
    static void Main()
    {
        Console.Title = title;
        new Screen();
        
        Console.WriteLine("\n\nGood bye fellas!");
    }
}