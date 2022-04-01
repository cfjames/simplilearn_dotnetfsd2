
namespace Phase1Section4._7b
{
    internal class SingleLinkedStringList
    {
        internal StringNode Root { get; private set; }

        internal int Length { get; private set; }

        internal StringNode Current { get; private set; }

        internal StringNode Next
        {
            get { return Current.Next; }
        }

        internal void Add(string data)
        { 
            StringNode newNode = new StringNode(data);
            Add(newNode);
        }

        internal void Add(StringNode node)
        {
            if (Root == null)
            {
                Root = node;
                Length = 1;
                Current = node;
            }
            else
            {
                if (Current.Next != null)
                { 
                    node.Next = Current.Next;
                }
                Current.Next = node;
                Current = node;
                Length++;
            }
        }

        internal void GoToStart()
        {
            Current = Root;
        }

        internal StringNode GetNext()
        { 
            Current = Current.Next;
            return Current;
        }
    }
}
