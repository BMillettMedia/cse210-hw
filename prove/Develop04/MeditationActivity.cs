using System;
using System.Threading;

public class MeditationActivity : Activity
{
    private IdleAnimation animation;

    public MeditationActivity(int duration)
    {
        Duration = duration;
        animation = new IdleAnimation(2); // Set interval for idle animation
    }

    protected override void PerformActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        Console.WriteLine("Take this time to clear your mind and focus on the present...");

        while (DateTime.Now < endTime)
        {
            animation.DisplayAnimation("Meditating..."); // Idle animation during meditation
        }

        Console.Clear();
        Console.WriteLine("Meditation session complete. Great job!");
    }
}
