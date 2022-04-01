
namespace Phase1Section4._7c
{
    //internal class DoubleLinkedList
    internal class DoubleLinkedList<T>
    {
        internal Node<T> Root { get; private set; }

        internal int Length { get; private set; }

        internal Node<T> Current { get; private set; }

        internal Node<T> Next
        {
            get { return Current.Next; }
        }

        internal Node<T> Previous
        {
            get { return Current.Previous; }
        }

        internal void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            Add(newNode);
        }

        internal void Add(Node<T> node)
        {
            if (Root == null)
            {
                Root = node;
                Length = 1;
                Current = node;
                Root.Previous = null;
            }
            else
            {
                if (Current.Next != null)
                {
                    Current.Next.Previous = node;
                    node.Next = Current.Next;
                }
                Current.Next = node;
                node.Previous = Current;
                Current = node;
                Length++;
            }
        }

        internal void GoToStart()
        {
            Current = Root;
        }

        internal Node<T> GetNext()
        {
            Node<T> ret = Current.Next;
            if (ret != null)
                Current = Current.Next;
            return ret;
        }

        internal Node<T> GetPrevious()
        {
            Node<T> ret = Current.Previous;
            if (ret != null)
                Current = Current.Previous;
            return ret;
        }
    }
}
