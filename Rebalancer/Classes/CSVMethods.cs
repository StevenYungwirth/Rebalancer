using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebalancer.Classes
{
    // ReSharper disable once InconsistentNaming
    public static class CSVMethods
    {
        public static List<string[]> Get_CSV_Data(string path)
        {
            // Hold the data
            List<string[]> csvData = new List<string[]>();

            // Put each line of the csv file into the list
            StreamReader file = File.OpenText(path);
            while (!file.EndOfStream)
            {
                string csvRow = file.ReadLine();
                csvData.Add(Get_Split_Row(csvRow));
            }

            // Close the csv file
            file.Close();

            // Return the data
            return csvData;
        }

        public static List<string> Get_Header_Values(List<string[]> csvData)
        {
            // Return the column headers from the first row of the csv data
            return csvData[0].ToList();
        }

        private static string[] Get_Split_Row(string row)
        {
            string[] splitRow;

            if (row.Contains('"'))
            {
                // If there's a quotation mark in the row, then there's a name with a comma in it (i.e. "Smith, Bob")
                // Find the location of the quotation marks in the entire string
                int firstQuote = row.IndexOf('"');
                int lastQuote = row.IndexOf('"', firstQuote + 1);

                // Get the value between the two quotation marks
                string quotedString = row.Substring(firstQuote + 1, lastQuote - firstQuote - 1);

                // Count the commas before the quotation mark
                int commaCount = row.Remove(firstQuote).Split(',').Length - 1;

                // Remove the comma
                row = row.Remove(row.IndexOf(',', firstQuote), 1);

                // Split the row
                splitRow = row.Split(',');

                // Put the comma back in where it belongs
                splitRow[commaCount] = quotedString;
            }
            else
            {
                // The household doesn't have a quotation in the name. Split the row
                splitRow = row.Split(',');
            }

            return splitRow;
        }
    }
}
