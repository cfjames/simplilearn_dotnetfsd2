// See https://aka.ms/new-console-template for more information
using Phase1Section4._11;

//RunApp();
//Example of using Queue built in to .NET Platform
QueueExample();

void RunApp()
{
    IntegerQueue q = new IntegerQueue();
    int? testDequeue = q.Dequeue();
    Console.WriteLine(testDequeue.HasValue ?
        testDequeue.ToString() : "NULL");

    q.Enqueue(10);
    q.Enqueue(20);
    q.Enqueue(30);
    q.Enqueue(40);
    q.Enqueue(50);
    q.Enqueue(60);
    q.Enqueue(70);
    q.Enqueue(80);
    q.Enqueue(90);
    q.Enqueue(100);

    Console.WriteLine(q.ListQueue());

    Console.WriteLine(q.Dequeue());
    Console.WriteLine(q.Peek());
    Console.WriteLine(q.Dequeue());

    Console.WriteLine(q.ListQueue());
}

void QueueExample()
{
    Queue<string> numbers = new Queue<string>();
    numbers.Enqueue("one");
    numbers.Enqueue("two");
    numbers.Enqueue("three");
    numbers.Enqueue("four");
    numbers.Enqueue("five");

    // A queue can be enumerated without disturbing its contents.
    foreach (string number in numbers)
    {
        Console.WriteLine(number);
    }

    Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
    Console.WriteLine("Peek at next item to dequeue: {0}",
        numbers.Peek());
    Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

    // Create a copy of the queue, using the ToArray method and the
    // constructor that accepts an IEnumerable<T>.
    Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

    Console.WriteLine("\nContents of the first copy:");
    foreach (string number in queueCopy)
    {
        Console.WriteLine(number);
    }

    // Create an array twice the size of the queue and copy the
    // elements of the queue, starting at the middle of the
    // array.
    string[] array2 = new string[numbers.Count * 2];
    numbers.CopyTo(array2, numbers.Count);

    // Create a second queue, using the constructor that accepts an
    // IEnumerable(Of T).
    Queue<string> queueCopy2 = new Queue<string>(array2);

    Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
    foreach (string number in queueCopy2)
    {
        Console.WriteLine(number);
    }

    Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
        queueCopy.Contains("four"));

    Console.WriteLine("\nqueueCopy.Clear()");
    queueCopy.Clear();
    Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);
}