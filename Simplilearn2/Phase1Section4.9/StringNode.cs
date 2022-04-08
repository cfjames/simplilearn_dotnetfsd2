using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._9
{
    internal class StringNode
    {
        internal string Data { get; set; }
        internal StringNode Previous { get; set; }
        internal StringNode Next { get; set; }

        internal StringNode() { }
        internal StringNode(string data)
        { 
            Data = data;
        }
    }
}
