namespace CSVSearchExportApp
{
    abstract class BaseRecord
    {
        public string ListedItem { get; }
        public string StockPhoto { get; }
        public string Blurb { get; }

        public BaseRecord(string listedItem, string stockPhoto, string blurb)
        {
            ListedItem = listedItem;
            StockPhoto = stockPhoto;
            Blurb = blurb;
        }

        public abstract bool MatchesFilter(string searchTerm);
    }
}
