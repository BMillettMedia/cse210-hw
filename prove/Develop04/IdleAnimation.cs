using System;
using System.Threading;

public class IdleAnimation
{
    private int interval; // Interval in seconds for animation display

    public IdleAnimation(int intervalInSeconds)
    {
        interval = intervalInSeconds;
    }

    public void DisplayAnimation(string action)
    {
        char[] symbols = { '.', 'o', 'O', 'o', '.' }; // Smooth "breathing" effect

        for (int i = 0; i < symbols.Length; i++)
        {
            Console.Write($"\r{action} {symbols[i]} ");
            Thread.Sleep(interval * 200); // Adjust speed as needed
        }
    }
}
