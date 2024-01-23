using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
     class MainModel : IMainModel
    {

        public List<List<string>> GetData(string filePath)
        {
            string dataPath = "..\\..\\Data\\" + filePath;
            List<List<string>> dataString = CSVReader.GetDataCSV(dataPath);
            
            return dataString;
        }

    }
}
