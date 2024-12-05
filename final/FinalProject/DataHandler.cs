namespace CSVSearchExportApp
{
    class DataHandler
    {
        private List<string[]> _data;
        private string[] _headers;

        public DataHandler(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            _headers = lines[0].Split(',');
            _data = lines.Skip(1).Select(line => line.Split(',')).ToList();
        }

        public FinalRecord FilterAndAggregate(string category, string searchTerm)
        {
            List<ItemRecord> filteredItems = _data
                .Where(row => row[0].Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .Select(row => new ItemRecord(row[0], row[1], row[2]))
                .ToList();

            if (filteredItems.Count == 0)
            {
                return null;
            }

            FinalRecord finalRecord = new FinalRecord(_headers);

            foreach (var item in filteredItems)
            {
                finalRecord.AddField("Listed Item", item.ListedItem);
                finalRecord.AddField("@Stock Photo", item.StockPhoto);
                finalRecord.AddField("Blurb", item.Blurb);
            }

            return finalRecord;
        }

        public void SaveFinalRecord(FinalRecord record, string outputPath)
        {
            using (var writer = new StreamWriter(outputPath))
            {
                writer.WriteLine(record.GetHeaderRow());
                writer.WriteLine(record.ToString());
            }
        }
    }
}
