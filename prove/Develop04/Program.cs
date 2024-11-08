using System;

class Program
{
    static void Main()
    {
        try
        {
            Menu menu = new Menu();
            menu.Display();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}
