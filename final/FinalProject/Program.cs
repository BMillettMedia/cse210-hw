using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSVSearchExportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to the CSV file:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found. Exiting program.");
                return;
            }

            DataHandler dataHandler = new DataHandler(filePath);
            Menu menu = new Menu(dataHandler);
            menu.Display();
        }
    }
}
