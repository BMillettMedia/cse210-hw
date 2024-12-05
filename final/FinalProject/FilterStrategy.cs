namespace CSVSearchExportApp
{
    abstract class FilterStrategy
    {
        public abstract bool Matches(BaseRecord record, string searchTerm);
    }
}
