using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._9
{
    internal class StringStack
    {
        internal StringNode Root { get; private set; }
        internal int Length { get; private set; }
        internal StringNode Current { get; private set; }

        internal StringStack() { }
        internal StringStack(StringNode node) {
            Push(node);
        }
        internal StringStack(string data)
        {
            Push(data);
        }

        internal void Push(string data)
        {
            Push(new StringNode(data));
        }

            internal void Push(StringNode node)
        {
            node.Next = null;
            if (Root == null)
            {
                Root = node;
                Length = 1;
                Current = Root;
                Root.Previous = null;
            }
            else
            {
                Current.Next = node;
                node.Previous = Current;
                Current = node;
                Length++;
            }
        }

        internal string PopString()
        {
            return Pop().Data;
        }

        internal StringNode Pop()
        {
            StringNode ret = null;
            if (Current == Root)
            {
                ret = Current;
                Current = null;
                Root = null;
                Length = 0;
            }
            else if(Current != null)
            { 
                ret = Current;
                Current = ret.Previous;
                Current.Next = null;
                Length--;
            }
            return ret;
        }

        internal StringNode Peek()
        {
            return Current;
        }

        internal string ListContents()
        { 
            string ret = null;
            StringNode iterator = Root;
            while (iterator != null)
            {
                ret += iterator.Data + " ";
                iterator = iterator.Next;
            }

            return ret;
        }
    }
}
