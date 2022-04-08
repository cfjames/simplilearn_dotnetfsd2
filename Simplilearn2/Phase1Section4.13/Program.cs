// See https://aka.ms/new-console-template for more information
//RunApp();
RunBuiltin();

void RunApp()
{
    int[] grades =
        new int[] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };
    int searchItem;
    bool success;
    do
    {
        Console.WriteLine("Enter grade(int) to search for and press Enter:");
        string input = Console.ReadLine();
        success = int.TryParse(input, out searchItem);
    } while (!success);

    int index=0;
    bool found = false;
    foreach (int grade in grades)
    {
        if (grade == searchItem)
        { 
            Console.WriteLine($"{grade} was found at position {index}");
            found = true;
            break;
        }
        index++;
    }
    if (!found)
    { 
        index = -1;
        Console.WriteLine("Item not found");
    }

    

}

void RunBuiltin()
{
    List<int> grades =
        new List<int> { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };

    int searchItem = 0;
    bool success;
    do
    {
        Console.WriteLine("Enter marks to search and press Enter:");
        string input = Console.ReadLine();
        success = int.TryParse(input, out searchItem);
    } while (!success);

    int index = grades.FindIndex(grd => grd == searchItem);
    if (index == -1)
        Console.WriteLine("Item not found");
    else
        Console.WriteLine($"{searchItem} was found at position {index}");
}