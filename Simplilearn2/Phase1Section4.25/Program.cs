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

    int n = students.Length, i, j, counter = 0;
    bool didISwap;
    string val;
    for (i = 1; i < n; i++)
    {
        val = students[i];
        didISwap = true;
        for (j = i - 1; j >= 0 && didISwap;)
        {
            if (val.CompareTo(students[j]) < 0)
            {
                students[j + 1] = students[j];
                j--;
                students[j + 1] = val;
            }
            else didISwap = false;
            counter++;
        }
    }

    Console.WriteLine(counter);

    foreach (string s in students)
    {
        Console.WriteLine(s);
    }
}
