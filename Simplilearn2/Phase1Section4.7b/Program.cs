// See https://aka.ms/new-console-template for more information
using Phase1Section4._7b;

RunApp();

void RunApp()
{
    SingleLinkedStringList list = new SingleLinkedStringList();
    StringNode node = new StringNode();
    node.Data = "root";
    list.Add(node);

    for (int i = 1; i < 10; i++)
    {
        StringNode newNode = new StringNode(i.ToString());
        list.Add(newNode);
    }

    Console.WriteLine($"Length of singly linked list={list.Length}");
    //StringNode nodeRef = list.Root;
    //while (nodeRef != null)
    //{ 
    //    Console.WriteLine(nodeRef.Data);
    //    nodeRef = nodeRef.Next;
    //}
    if (list.Length != 0)
    {
        list.GoToStart();
        do
        {
            Console.WriteLine(list.Current.Data);
        } while (list.GetNext() != null);
    }
}