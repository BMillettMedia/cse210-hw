using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace CSVSearchExportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file path to CSV file:")
            string filePath = Console.ReadLine();

            if (!File.Exists(File))
            {
                Console.WriteLine("File not found. Exiting program.")
                return;
            }

            DataHandler dataHandler = new dataHandler(filepath);
            Menu menu = new Menu(dataHandler);
            menu.Display();
        }
    }

}

