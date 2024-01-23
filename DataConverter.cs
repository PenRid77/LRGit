using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    static class DataConverter
    {

        static public List<List<float>> ConvertStringToFloat(List<List<string>> data)
        {
            List<List<float>> dataFloat = new List<List<float>>();
           
            for (int i = 1; i < data.Count; i++)
            {
                
                    try { dataFloat.Add(ConvertStringListToFloatList(data[i])); }
                    catch { }
                
                
                   
                
            }
            return dataFloat;
        }
        static private List<float> ConvertStringListToFloatList(List<string> strings)
        {
            List<float> floatList = new List<float>(); 
            for (int i = 0; i < strings.Count; i++)
            {
                try
                {
                    floatList.Add(float.Parse(strings[i]));
                }
               catch { }
            }
            return floatList;
        }
    }
}
