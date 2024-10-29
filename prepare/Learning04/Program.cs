using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("");
        Console.WriteLine(a1.GetSummary());

        Math a2 = New Math("", "", "", "");
        Console.WriteLine(a2.GetSummarry());
        Console.WriteLine(a2.GetHomeworkList());

        Writing a3 = new Writing("", "", "");
        Console.WriteLine(a3.GetSummarry());
        Console.WriteLine(a3.GetWritingInfo());


    }
}