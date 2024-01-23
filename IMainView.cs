using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public interface IMainView : IView
    {
       
        event Action ShowedRunnerStats;
        void DrawData(List<List<string>> data);
        void DrawGraphic(Dot[] dots);
        void ClearGraphic();

    }
}
