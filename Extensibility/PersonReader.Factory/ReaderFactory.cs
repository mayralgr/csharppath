using System;
using PersonReader.CSV;
using PersonReader.Interface;
using PersonReader.Service;
using PersonReader.SQL;

namespace PersonReader.Factory
{
    public class ReaderFactory
    {
        public IPersonReader GetReader(string readearType)
        {
            switch (readearType)
            {
                case "Service": return new ServiceReader();
                case "CSV": return new CSVReader();
                case "SQL": return new SQLReader();
                default: throw new ArgumentException($"Invalid reader type: {readearType}");
            }
        }
    }
}
