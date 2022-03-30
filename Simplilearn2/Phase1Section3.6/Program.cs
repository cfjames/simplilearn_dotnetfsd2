// See https://aka.ms/new-console-template for more information
DoApp();

void DoApp()
{
    int x = 10;
    if (x >= 10)
        Console.WriteLine("This is an if branch");
    else
        Console.WriteLine("This is an else branch");

    switch (x)
    {
        case <=7:
            Console.WriteLine("This runs for values 7 and lower");
            break;
        case 8 or 9:
            Console.WriteLine("This runs for the values 8 or 9");
            break;
        case 10:
            Console.WriteLine("This runs for the value 10");
            break;
        default:
            Console.WriteLine("This runs if nothing else matches");
            break;
    }

    while (x < 20)
    { 
        x++;
        Console.WriteLine("Incrementing x in a while loop: " + x);
    }

    do
    {
        x--;
        Console.WriteLine("Decrementing x in a do-while loop: " + x);
    } while (x >= 10);

    for (int i = 0; i <= x; i++)
    {
        Console.WriteLine("For loop assinging value: " + i);
    }

    string[] numbers = { "One", "Two", "Three", "Four", "Five" };
    foreach(string number in numbers)
        Console.WriteLine("Foreach loop assigning value: " + number);

}