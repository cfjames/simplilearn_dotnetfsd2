using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section6._8
{
    interface IDouble
    {
        int Calculate(int a);
    }

    class Addition : IDouble
    {
        public int Calculate(int a)
        {
            return a + a;
        }

    }

    class Multiply : IDouble
    {
        public int Calculate(int a)
        {
            return a * 2;
        }

    }

    class CalculateContext
    {
        private IDouble _double;

        public CalculateContext() { }

        public CalculateContext(IDouble d)        
        {
            SetDouble(d);
        }

        public void SetDouble(IDouble d)
        {
            _double = d;
        }

        public int Double(int number)
        {
            return _double.Calculate(number);
        }
    }
}
