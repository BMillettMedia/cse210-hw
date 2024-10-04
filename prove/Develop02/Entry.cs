//New Entry Management
using System
punlic class Entry
{
    //attributes
    public string Date { get; set;}
    public string Prompt { get; set;}
    public string Response { get; set;}

    //Constructor
    public Entry(String date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    //behavior
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }
}