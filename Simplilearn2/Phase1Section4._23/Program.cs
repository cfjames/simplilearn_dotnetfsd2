// See https://aka.ms/new-console-template for more information
RunApp();

void RunApp()
{
    string[] students = new string[10];
    students[0] = "Karuna";
    students[1] = "Mark";
    students[2] = "Guru";
    students[3] = "Sangeeta";
    students[4] = "Nazia";
    students[5] = "Faisal";
    students[6] = "Tania";
    students[7] = "Advaith";
    students[8] = "Chandni";
    students[9] = "Kamleshwar";

    foreach (string s in students)
    {
        Console.WriteLine(s);
    }

    Console.WriteLine();

    int maxIndex = students.Length;
    string temp;
    int smallest;
    int counter = 0;
    for (int i = 0; i < maxIndex - 1; i++)
    {
        smallest = i;
        for (int j = i + 1; j < maxIndex; j++)
        {
            if (students[j].CompareTo(students[smallest]) < 0)
            {
                smallest = j;
            }
            counter++;
        }
        temp = students[smallest];
        students[smallest] = students[i];
        students[i] = temp;
    }

    Console.WriteLine(counter);
    foreach (string s in students)
    {
        Console.WriteLine(s);
    }
}
