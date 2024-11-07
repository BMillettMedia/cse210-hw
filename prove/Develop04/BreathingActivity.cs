using System;
using System.Threading;

public class BreathingActivity : Activity
{
    protected override void PerformActivity()
    {
        Console.WriteLine("This activity will guide you through paced breathing.");
        int interval = 5; // seconds per inhale/exhale cycle

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(interval * 1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(interval * 1000);
            Console.WriteLine("Breathe in...");
            Thread.Sleep(interval * 1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(interval * 1000);
            Console.WriteLine("Breathe in...");
            Thread.Sleep(interval * 1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(interval * 1000);
        }
    }
}
