using System;
using System.Formats.Asn1;
using System.Globalization;

namespace Galytix.Services
{
	public class CSVService: ICSVService
	{
		public CSVService()
		{
		}

        public IEnumerable<T> ReadCSV<T>()
        {
            var reader = new StreamReader("./Data/gwpByCountry.csv");
            var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<T>();
            return records;
        }
    }
}

