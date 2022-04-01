namespace Phase1Section4._7c
{
    //internal class Node
    internal class Node<T>
    {
        //internal string Data { get; set; }
        internal T Data { get; set; }
        internal Node<T> Previous { get; set; }
        internal Node<T> Next { get; set; }

        internal Node() { }
        //internal Node(string data)
        internal Node(T data)
        { 
            Data = data;
        }
    }
}
