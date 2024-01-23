using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LR2
{
     static class CSVReader
    {
        static public List<List<string>> GetDataCSV(string filePath)
        {
            List<List<string>> data = new List<List<string>>();
            using (StreamReader reader = new StreamReader(filePath, Encoding.Default))
            {
                string headerLine = reader.ReadLine();
                string[] headers = headerLine.Split(';');
                data.Add(headers.ToList<string>());
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(';');
                    data.Add(values.ToList<string>());

                }
                
            }
            
            return data;
        }
    }
}
