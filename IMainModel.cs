using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    interface IMainModel
    {
        List<List<string>> GetData(string filePath);
    }
}
