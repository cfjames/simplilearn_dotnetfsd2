using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase4Section1.UnitTests
{
    public interface IDyanamicCalc
    {
        dynamic Add(Object x, Object y);
    }

    public class DynamicTestCalculator : IDyanamicCalc
    {
        public dynamic Add(object x, object y)
        {
            if (x.GetType() == typeof(int) && y.GetType() == typeof(int))
                return (int)x + (int)y;
            else if (x.GetType() == typeof(string) && y.GetType() == typeof(string) &&
                int.TryParse(x.ToString(), out int a) && int.TryParse(x.ToString(), out int b))
            {
                return a + b;
            }
            else
                return 0;
        }
    }

}
