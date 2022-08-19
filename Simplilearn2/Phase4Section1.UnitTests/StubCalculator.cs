using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase4Section1.UnitTests
{
    internal class StubCalculator : ICalculator
    {
        public int Add(int x, int y)
        {
            return 10;
        }

        public int Add(string x, string y)
        {
            return 5;
        }

        public int Subtract(int x, int y)
        {
            return 2;
        }
    }
}
