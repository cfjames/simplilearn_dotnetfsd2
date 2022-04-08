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

    foreach(string student in students)
        Console.WriteLine(student);

    Console.WriteLine();

    int counter = 0;
    bool didISwap = true;
    string temp;
    int maxIndex = students.Length - 1;
    int maxPasses = maxIndex;
    for (int i = 0; (i <= maxPasses) && didISwap; i++)
    {
        didISwap = false;
        for (int j = 0; j < maxIndex; j++)
        {
            if (students[j + 1].CompareTo(students[j]) < 0)
            { 
                temp = students[j];
                students[j] = students[j + 1];
                students[j + 1] = temp;
                didISwap = true;
            }
            counter++;
        }

        maxIndex--;
    }

    foreach (string student in students)
        Console.WriteLine(student);
}