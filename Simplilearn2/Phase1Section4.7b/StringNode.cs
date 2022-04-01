namespace Phase1Section4._7b
{
    internal class StringNode
    {
        internal string Data { get; set; }
        internal StringNode Next { get; set; }

        internal StringNode() { }
        internal StringNode(string data)
        { 
            Data = data;
        }
    }
}
