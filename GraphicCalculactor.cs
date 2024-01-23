using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    static class GraphicCalculactor
    {
        static public Dot[] CalculateGraphicDots(List<List<float>> data)
        {
            List<Dot> dots = new List<Dot>();
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i][0].ToString() + data[i][1].ToString());
               
                    Dot dot = new Dot(data[i][0], data[i][1]);
                    dots.Add(dot);
            }
            return dots.ToArray();

        }
    }
}
