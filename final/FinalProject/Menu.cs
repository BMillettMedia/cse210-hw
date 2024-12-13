using System;

namespace CSVSearchExportApp
{
    public class Menu
    {
        private readonly DataHandler _dataHandler;

        public Menu(DataHandler dataHandler)
        {
            _dataHandler = dataHandler;
        }

        public void Run()
        {
            FinalRecord record = new FinalRecord();

            // Collect and populate the record with user inputs
            _dataHandler.CollectAndPopulateRecord(record);

            // Export the final record to CSV
            _dataHandler.ExportRecord(record, "exported_data.csv");
        }
    }
}
