namespace CSVSearchExportApp
{
    class SimpleFilterStrategy : FilterStrategy
    {
        public override bool Matches(BaseRecord record, string searchTerm)
        {
            return record.ListedItem.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
        }
    }
}
