namespace CSVSearchExportApp
{
    class Menu
    {
        private DataHandler _dataHandler;

        public Menu(DataHandler dataHandler)
        {
            _dataHandler = dataHandler;
        }

        public void Display()
        {
            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Search and Export Items");
                Console.WriteLine("2. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SearchAndAggregate();
                        break;
                    case "2":
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void SearchAndAggregate()
        {
            Console.WriteLine("Enter search category (e.g., 'Meat'):");
            string category = Console.ReadLine();

            Console.WriteLine("Enter search term (e.g., 'Beef'):");
            string searchTerm = Console.ReadLine();

            FinalRecord filteredRecord = _dataHandler.FilterAndAggregate(category, searchTerm);

            if (filteredRecord == null || string.IsNullOrEmpty(filteredRecord.ToString()))
            {
                Console.WriteLine("No items found for your search.");
                return;
            }

            Console.WriteLine("Enter the output CSV file name (e.g., 'output.csv'):");
            string outputFileName = Console.ReadLine();

            _dataHandler.SaveFinalRecord(filteredRecord, outputFileName);
            Console.WriteLine($"Results have been saved to '{outputFileName}'");
        }
    }
}
