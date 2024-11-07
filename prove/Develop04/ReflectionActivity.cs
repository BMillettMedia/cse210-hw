using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private static readonly string[] Prompts = {
        "Think of a time you were strong.",
        "Think of a time you helped others."
    };

    private static readonly string[] Questions = {
        "Why was it meaningful?",
        "How did it start?",
        "What did you learn?"
    };

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(Questions[random.Next(Questions.Length)]);
            ShowSpinner();
        }
    }
}
