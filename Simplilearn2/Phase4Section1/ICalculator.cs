using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase4Section1
{
    public interface ICalculator
    {
        int Add(int x, int y);
        int Add(string x, string y);
        int Subtract(int x, int y);
    }
}
