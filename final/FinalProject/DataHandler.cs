using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSVSearchExportApp
{
    public class DataHandler
    {
        private readonly string _filePath;

        public DataHandler(string filePath)
        {
            _filePath = filePath;
        }

        // Method to export the data to CSV
        public void ExportRecord(FinalRecord record, string fileName)
        {
            try
            {
                var headers = FinalRecord.GetCsvHeaders();
                var values = record.ToCsvRow();

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(string.Join(",", headers)); // Write headers
                    writer.WriteLine(string.Join(",", values)); // Write record values
                }

                Console.WriteLine($"Record successfully exported to {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error exporting record: {ex.Message}");
            }
        }

        // Method to collect user input for a specific category and populate the record
        public void CollectAndPopulateRecord(FinalRecord record)
        {
            // Load data from the source CSV
            var csvData = LoadCsvData(_filePath);

            // Ask for 3 meat items
            Console.WriteLine("Please enter 3 meat items (Listed Item, Stock Photo, and Blurb):");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Meat {i}:");
                Console.Write($"Listed Item-Meat-{i}: ");
                string meatName = Console.ReadLine();

                // Check if meat item exists in the source data and auto-populate
                var meatItem = csvData.FirstOrDefault(row => row[0] == meatName); // Assuming the listed item is in column 0
                if (meatItem != null)
                {
                    if (i == 1)
                    {
                        record.Meat1 = meatItem[0];
                        record.Meat1Photo = meatItem[1]; // @Stock Photo-Meat is in column 1
                        record.Meat1Blurb = meatItem[2]; // Blurb-Meat is in column 2
                    }
                    else if (i == 2)
                    {
                        record.Meat2 = meatItem[0];
                        record.Meat2Photo = meatItem[1];
                        record.Meat2Blurb = meatItem[2];
                    }
                    else
                    {
                        record.Meat3 = meatItem[0];
                        record.Meat3Photo = meatItem[1];
                        record.Meat3Blurb = meatItem[2];
                    }
                }
                else
                {
                    // Prompt the user to input data if no matching meat item is found in CSV
                    if (i == 1)
                    {
                        record.Meat1 = meatName;
                        record.Meat1Photo = GetUserInput($"@Stock Photo-Meat-{i}: ");
                        record.Meat1Blurb = GetUserInput($"Blurb-Meat-{i}: ");
                    }
                    else if (i == 2)
                    {
                        record.Meat2 = meatName;
                        record.Meat2Photo = GetUserInput($"@Stock Photo-Meat-{i}: ");
                        record.Meat2Blurb = GetUserInput($"Blurb-Meat-{i}: ");
                    }
                    else
                    {
                        record.Meat3 = meatName;
                        record.Meat3Photo = GetUserInput($"@Stock Photo-Meat-{i}: ");
                        record.Meat3Blurb = GetUserInput($"Blurb-Meat-{i}: ");
                    }
                }
            }

            // Ask for 1 pairing item
            Console.WriteLine("Please enter 1 pairing item (Listed Item, Stock Photo, and Blurb):");
            Console.Write("Listed Item-Pairing: ");
            string pairingName = Console.ReadLine();

            // Check if pairing item exists in the source data and auto-populate
            var pairingItem = csvData.FirstOrDefault(row => row[8] == pairingName); // Column 8 contains @Product Photo-Pairing
            if (pairingItem != null)
            {
                record.Pairing = pairingItem[7]; // Listed Item-Pairing is in column 7
                record.PairingPhoto = pairingItem[8]; // @Product Photo-Pairing is in column 8
                record.PairingBlurb = pairingItem[9]; // Blurb-Pairing is in column 9
            }
            else
            {
                // Prompt the user to input data if no matching pairing item is found in CSV
                record.Pairing = pairingName;
                record.PairingPhoto = GetUserInput("@Product Photo-Pairing: ");
                record.PairingBlurb = GetUserInput("Blurb-Pairing: ");
            }

            // Ask for 2 produce items
            Console.WriteLine("Please enter 2 produce items (Listed Item, Stock Photo, and Blurb):");
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Produce {i}:");
                Console.Write($"Listed Item-Produce-{i}: ");
                string produceName = Console.ReadLine();

                // Check if produce item exists in the source data and auto-populate
                var produceItem = csvData.FirstOrDefault(row => row[3] == produceName); // Column 3 for Listed Item-Produce
                if (produceItem != null)
                {
                    if (i == 1)
                    {
                        record.Produce1 = produceItem[3]; // Listed Item-Produce
                        record.Produce1Photo = produceItem[4]; // @Stock Photo-Produce
                        record.Produce1Blurb = produceItem[5]; // Blurb-Produce
                    }
                    else
                    {
                        record.Produce2 = produceItem[3];
                        record.Produce2Photo = produceItem[4];
                        record.Produce2Blurb = produceItem[5];
                    }
                }
                else
                {
                    // Prompt the user to input data if no matching produce item is found in CSV
                    if (i == 1)
                    {
                        record.Produce1 = produceName;
                        record.Produce1Photo = GetUserInput($"@Stock Photo-Produce-{i}: ");
                        record.Produce1Blurb = GetUserInput($"Blurb-Produce-{i}: ");
                    }
                    else
                    {
                        record.Produce2 = produceName;
                        record.Produce2Photo = GetUserInput($"@Stock Photo-Produce-{i}: ");
                        record.Produce2Blurb = GetUserInput($"Blurb-Produce-{i}: ");
                    }
                }
            }

            // Ask for 2 deli items
            Console.WriteLine("Please enter 2 deli items (Listed Item, Stock Photo, and Blurb):");
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Deli {i}:");
                Console.Write($"Listed Item-Deli-{i}: ");
                string deliName = Console.ReadLine();

                // Check if deli item exists in the source data and auto-populate
                var deliItem = csvData.FirstOrDefault(row => row[10] == deliName); // Column 10 for Listed Item-Deli
                if (deliItem != null)
                {
                    if (i == 1)
                    {
                        record.Deli1 = deliItem[10];
                        record.Deli1Photo = deliItem[11]; // @Stock Photo-Deli
                        record.Deli1Blurb = deliItem[12]; // Blurb-Deli
                    }
                    else
                    {
                        record.Deli2 = deliItem[10];
                        record.Deli2Photo = deliItem[11];
                        record.Deli2Blurb = deliItem[12];
                    }
                }
                else
                {
                    // Prompt the user to input data if no matching deli item is found in CSV
                    if (i == 1)
                    {
                        record.Deli1 = deliName;
                        record.Deli1Photo = GetUserInput($"@Stock Photo-Deli-{i}: ");
                        record.Deli1Blurb = GetUserInput($"Blurb-Deli-{i}: ");
                    }
                    else
                    {
                        record.Deli2 = deliName;
                        record.Deli2Photo = GetUserInput($"@Stock Photo-Deli-{i}: ");
                        record.Deli2Blurb = GetUserInput($"Blurb-Deli-{i}: ");
                    }
                }
            }

            // Ask for 1 bakery item
            Console.WriteLine("Please enter 1 bakery item (Listed Item, Stock Photo, and Blurb):");
            Console.Write("Listed Item-Bakery: ");
            string bakeryName = Console.ReadLine();

            // Check if bakery item exists in the source data and auto-populate
            var bakeryItem = csvData.FirstOrDefault(row => row[13] == bakeryName); // Column 13 for Listed Item-Bakery
            if (bakeryItem != null)
            {
                record.Bakery = bakeryItem[13]; // Listed Item-Bakery
                record.BakeryPhoto = bakeryItem[14]; // @Product Photo-Bakery
                record.BakeryBlurb = bakeryItem[15]; // Blurb-Bakery
            }
            else
            {
                // Prompt the user to input data if no matching bakery item is found in CSV
                record.Bakery = bakeryName;
                record.BakeryPhoto = GetUserInput("@Product Photo-Bakery: ");
                record.BakeryBlurb = GetUserInput("Blurb-Bakery: ");
            }

            // Ask for 2 cheese items
            Console.WriteLine("Please enter 2 cheese items (Listed Item, Stock Photo, and Blurb):");
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Cheese {i}:");
                Console.Write($"Listed Item-Cheese-{i}: ");
                string cheeseName = Console.ReadLine();

                // Check if cheese item exists in the source data and auto-populate
                var cheeseItem = csvData.FirstOrDefault(row => row[16] == cheeseName); // Column 16 for Listed Item-Cheese
                if (cheeseItem != null)
                {
                    if (i == 1)
                    {
                        record.Cheese1 = cheeseItem[16]; // Listed Item-Cheese
                        record.Cheese1Photo = cheeseItem[17]; // @Product Photo-Cheese
                        record.Cheese1Blurb = cheeseItem[18]; // Blurb-Cheese
                    }
                    else
                    {
                        record.Cheese2 = cheeseItem[16];
                        record.Cheese2Photo = cheeseItem[17];
                        record.Cheese2Blurb = cheeseItem[18];
                    }
                }
                else
                {
                    // Prompt the user to input data if no matching cheese item is found in CSV
                    if (i == 1)
                    {
                        record.Cheese1 = cheeseName;
                        record.Cheese1Photo = GetUserInput("@Product Photo-Cheese-{i}: ");
                        record.Cheese1Blurb = GetUserInput($"Blurb-Cheese-{i}: ");
                    }
                    else
                    {
                        record.Cheese2 = cheeseName;
                        record.Cheese2Photo = GetUserInput("@Product Photo-Cheese-{i}: ");
                        record.Cheese2Blurb = GetUserInput($"Blurb-Cheese-{i}: ");
                    }
                }
            }
        }

        // Helper method to load the CSV data
        public List<List<string>> LoadCsvData(string filePath)
        {
            var csvLines = File.ReadAllLines(filePath);
            var data = new List<List<string>>();

            foreach (var line in csvLines.Skip(1)) // Skip header
            {
                var columns = line.Split(',').ToList();
                data.Add(columns);
            }

            return data;
        }

        // Helper method for user input
        private string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }

    
}
