using System;
using System.IO;

namespace CSVSearchExportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the file name
            string filePath = "SampleData.csv";

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File '{filePath}' not found. Ensure it is in the same directory as the program.");
                return;
            }

            // Load the data and start the menu
            DataHandler dataHandler = new DataHandler(filePath);
            Menu menu = new Menu(dataHandler);
            menu.Display();
        }
    }
}
