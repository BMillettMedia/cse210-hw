namespace CSVSearchExportApp
{
    class ItemRecord : BaseRecord
    {
        public ItemRecord(string listedItem, string stockPhoto, string blurb)
            : base(listedItem, stockPhoto, blurb) { }

        public override bool MatchesFilter(string searchTerm)
        {
            return ListedItem.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
        }
    }
}
