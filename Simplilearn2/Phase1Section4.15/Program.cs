// See https://aka.ms/new-console-template for more information
RunApp();

void RunApp()
{

    int[] grades =
        new int[] { 44, 56, 67, 76, 79, 82, 83, 88, 90, 98};
    
    int searchItem;
    bool success;
    do
    {
        Console.WriteLine("Enter grade(int) to search for and press Enter:");
        string input = Console.ReadLine();
        success = int.TryParse(input, out searchItem);
    } while (!success);

    int minIndex = 0;
    int maxIndex = grades.Length -1;

    int foundIndex = -1;

    while (minIndex <= maxIndex && foundIndex == -1)
    { 
        int mid = (minIndex + maxIndex) / 2;
        if (searchItem == grades[mid])
        {
            foundIndex = mid;
            break;
        }
        else if (searchItem < grades[mid])
        {
            maxIndex = mid - 1;
        }
        else
        {
            minIndex = mid + 1;
        }
    }

    if (foundIndex == -1)
        Console.WriteLine("Item not found");
    else
        Console.WriteLine($"{searchItem} was found at position {foundIndex}");
}