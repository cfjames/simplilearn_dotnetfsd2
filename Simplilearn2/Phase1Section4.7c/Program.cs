// See https://aka.ms/new-console-template for more information
using Phase1Section4._7c;
using System.Text;

RunApp();
//Example of LinkedList that comes with the framework
//LinkedListExample();

void RunApp()
{
    DoubleLinkedList<string> list = new DoubleLinkedList<string>();
    list.Add("root");
    for (int i = 1; i < 10; i++)
    {
        Node<string> newNode = new Node<string>(i.ToString());
        list.Add(newNode);
    }

    Console.WriteLine($"Length of doubly linked list={list.Length}");
    Console.WriteLine("Traversing forward..");
    if (list.Length != 0)
    {
        list.GoToStart();
        do
        {
            Console.WriteLine(list.Current.Data);
        } while (list.GetNext() != null);
    }

    Console.WriteLine("Traversing backwards..");
    if (list.Length != 0)
    {
        do
        {
            Console.WriteLine(list.Current.Data);
        } while (list.GetPrevious() != null);
    }

    //Same example but with ints
    DoubleLinkedList<int> intList = new DoubleLinkedList<int>();
    intList.Add(0);
    for (int i = 1; i < 10; i++)
    {
        Node<int> newNode = new Node<int>(i);
        intList.Add(newNode);
    }

    Console.WriteLine($"Length of doubly linked list={list.Length}");
    Console.WriteLine("Traversing forward..");
    if (intList.Length != 0)
    {
        intList.GoToStart();
        do
        {
            Console.WriteLine(intList.Current.Data);
        } while (intList.GetNext() != null);
    }

    Console.WriteLine("Traversing backwards..");
    if (intList.Length != 0)
    {
        do
        {
            Console.WriteLine(intList.Current.Data);
        } while (intList.GetPrevious() != null);
    }
}

void LinkedListExample()
{
    string[] words =
                { "the", "fox", "jumps", "over", "the", "dog" };
    LinkedList<string> sentence = new LinkedList<string>(words);
    Display(sentence, "The linked list values:");
    Console.WriteLine($"sentence contains the word jumps = {sentence.Contains("jumps")}");

    // Add the word 'today' to the beginning of the linked list.
    sentence.AddFirst("today");
    Display(sentence, "Test 1: Add 'today' to beginning of the list:");

    // Move the first node to be the last node.
    LinkedListNode<string> mark1 = sentence.First;
    sentence.RemoveFirst();
    sentence.AddLast(mark1);
    Display(sentence, "Test 2: Move first node to be last node:");

    // Change the last node to 'yesterday'.
    sentence.RemoveLast();
    sentence.AddLast("yesterday");
    Display(sentence, "Test 3: Change the last node to 'yesterday':");

    // Move the last node to be the first node.
    mark1 = sentence.Last;
    sentence.RemoveLast();
    sentence.AddFirst(mark1);
    Display(sentence, "Test 4: Move last node to be first node:");

    // Indicate the last occurence of 'the'.
    sentence.RemoveFirst();
    LinkedListNode<string> current = sentence.FindLast("the");
    IndicateNode(current, "Test 5: Indicate last occurence of 'the':");

    // Add 'lazy' and 'old' after 'the' (the LinkedListNode named current).
    sentence.AddAfter(current, "old");
    sentence.AddAfter(current, "lazy");
    IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the':");

    // Indicate 'fox' node.
    current = sentence.Find("fox");
    IndicateNode(current, "Test 7: Indicate the 'fox' node:");

    // Add 'quick' and 'brown' before 'fox':
    sentence.AddBefore(current, "quick");
    sentence.AddBefore(current, "brown");
    IndicateNode(current, "Test 8: Add 'quick' and 'brown' before 'fox':");

    // Keep a reference to the current node, 'fox',
    // and to the previous node in the list. Indicate the 'dog' node.
    mark1 = current;
    LinkedListNode<string> mark2 = current.Previous;
    current = sentence.Find("dog");
    IndicateNode(current, "Test 9: Indicate the 'dog' node:");

    // The AddBefore method throws an InvalidOperationException
    // if you try to add a node that already belongs to a list.
    Console.WriteLine("Test 10: Throw exception by adding node (fox) already in the list:");
    try
    {
        sentence.AddBefore(current, mark1);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("Exception message: {0}", ex.Message);
    }
    Console.WriteLine();

    // Remove the node referred to by mark1, and then add it
    // before the node referred to by current.
    // Indicate the node referred to by current.
    sentence.Remove(mark1);
    sentence.AddBefore(current, mark1);
    IndicateNode(current, "Test 11: Move a referenced node (fox) before the current node (dog):");

    // Remove the node referred to by current.
    sentence.Remove(current);
    IndicateNode(current, "Test 12: Remove current node (dog) and attempt to indicate it:");

    // Add the node after the node referred to by mark2.
    sentence.AddAfter(mark2, current);
    IndicateNode(current, "Test 13: Add node removed in test 11 after a referenced node (brown):");

    // The Remove method finds and removes the
    // first node that that has the specified value.
    sentence.Remove("old");
    Display(sentence, "Test 14: Remove node that has the value 'old':");

    // When the linked list is cast to ICollection(Of String),
    // the Add method adds a node to the end of the list.
    sentence.RemoveLast();
    ICollection<string> icoll = sentence;
    icoll.Add("rhinoceros");
    Display(sentence, "Test 15: Remove last node, cast to ICollection, and add 'rhinoceros':");

    Console.WriteLine("Test 16: Copy the list to an array:");
    // Create an array with the same number of
    // elements as the linked list.
    string[] sArray = new string[sentence.Count];
    sentence.CopyTo(sArray, 0);

    foreach (string s in sArray)
    {
        Console.WriteLine(s);
    }

    // Release all the nodes.
    sentence.Clear();

    Console.WriteLine();
    Console.WriteLine("Test 17: Clear linked list. Contains 'jumps' = {0}",
        sentence.Contains("jumps"));

    Console.ReadLine();
}

void Display(LinkedList<string> words, string test)
{
    Console.WriteLine(test);
    foreach (string word in words)
    {
        Console.Write(word + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void IndicateNode(LinkedListNode<string> node, string test)
{
    Console.WriteLine(test);
    if (node.List == null)
    {
        Console.WriteLine("Node '{0}' is not in the list.\n",
            node.Value);
        return;
    }

    StringBuilder result = new StringBuilder("(" + node.Value + ")");
    LinkedListNode<string> nodeP = node.Previous;

    while (nodeP != null)
    {
        result.Insert(0, nodeP.Value + " ");
        nodeP = nodeP.Previous;
    }

    node = node.Next;
    while (node != null)
    {
        result.Append(" " + node.Value);
        node = node.Next;
    }

    Console.WriteLine(result);
    Console.WriteLine();
}