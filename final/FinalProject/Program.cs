using System;

namespace CSVSearchExportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "SampleData.csv"; // Replace with your actual file path
            DataHandler dataHandler = new DataHandler(filePath);
            Menu menu = new Menu(dataHandler);

            menu.Run();
        }
    }
}
