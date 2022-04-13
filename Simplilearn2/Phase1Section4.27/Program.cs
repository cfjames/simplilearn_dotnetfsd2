// See https://aka.ms/new-console-template for more information
RunApp();
//More real world example
//Console.WriteLine(FactorialRecursion(9));

void RunApp()
{
    string[] students = new string[10];
    students[0] = "Karuna";
    students[1] = "Mark";
    students[2] = "Advaith";
    students[3] = "Sangeeta";
    students[4] = "Nazia";
    students[5] = "Faisal";
    students[6] = "Tania";
    students[7] = "Guru";
    students[8] = "Chandni";
    students[9] = "Kamleshwar";

    int currElem = 0;
    PrintViaRecursion(students, currElem);
}

void PrintViaRecursion(string[] arr, int currElem)
{
    Console.WriteLine(arr[currElem]);
    if (currElem < arr.Length - 1)
        PrintViaRecursion(arr, currElem + 1);
}

double FactorialRecursion(int number)
{
    if (number == 1)
        return 1;
    else
    {
        double previousFac = FactorialRecursion(number - 1);
        return number * previousFac;
    }
}