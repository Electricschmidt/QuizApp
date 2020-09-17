using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.StaticFiles;

namespace QuizApp
{
    public class CsvReader
    {
        public string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }

        public List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                // read header line
                sr.ReadLine();

                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsvLine(csvLine));
                }
            }

            return countries;
        }
        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            string name = parts[0];
            string cap = parts[1];
            string region = parts[5];

            return new Country(name, cap, region);
        }
    }
}
