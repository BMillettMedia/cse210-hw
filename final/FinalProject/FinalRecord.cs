using System.Collections.Generic;
using System.Text;

namespace CSVSearchExportApp
{
    class FinalRecord
    {
        private Dictionary<string, string> _fields;

        public FinalRecord(IEnumerable<string> headers)
        {
            _fields = headers.ToDictionary(header => header, header => string.Empty);
        }

        public void AddField(string header, string value)
        {
            if (_fields.ContainsKey(header))
            {
                _fields[header] = value;
            }
        }

        public string GetHeaderRow()
        {
            return string.Join(",", _fields.Keys);
        }

        public override string ToString()
        {
            return string.Join(",", _fields.Values);
        }
    }
}
