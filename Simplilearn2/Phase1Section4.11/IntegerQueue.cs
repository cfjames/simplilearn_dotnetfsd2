using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._11
{
    internal class IntegerQueue
    {
        private List<int> _elements;

        internal int Count { get { return _elements.Count; } }

        internal IntegerQueue()
        { 
            _elements = new List<int>();
        }

        internal void Enqueue(int item)
        { 
            _elements.Add(item);
        }

        internal int? Dequeue()
        { 
            int? result = Peek();
            if (result.HasValue)
                _elements.RemoveAt(0);

            return result;
        }

        internal int? Peek()
        { 
            if(_elements.Count == 0)
                return null;

            return _elements[0];
        }

        internal string ListQueue()
        {
            string result = "";
            if (Count != 0)
            {
                foreach (int item in _elements)
                    result += item + " ";
            }
            
            return result;
        }
    }
}
