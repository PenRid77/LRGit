using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    static class GraphicCalculactor
    {
        static public Dot[] CalculateGraphicDots(List<List<float>> data, int indexY)
        {
            List<Dot> dots = new List<Dot>();
            for (int i = 0; i < data.Count; i++)
            {
                
               
                    Dot dot = new Dot(data[i][0], data[i][indexY]);
                    dots.Add(dot);
            }
            return dots.ToArray();

        }
    }
}
