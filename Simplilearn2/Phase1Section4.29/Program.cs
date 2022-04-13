// See https://aka.ms/new-console-template for more information
RunApp();

void RunApp()
{
    int[] marks = new int[10];
    marks[0] = 80;
    marks[1] = 90;
    marks[2] = 93;
    marks[3] = 76;
    marks[4] = 77;
    marks[5] = 92;
    marks[6] = 89;
    marks[7] = 78;
    marks[8] = 80;
    marks[9] = 56;

    int i, j, gap;
    int temp;
    gap = 3;
    while (gap > 0)
    {
        for (i = 0; i < marks.Length; i++)
        {
            j = i;
            temp = marks[i];
            while ((j >= gap) && (marks[j - gap] > temp))
            {
                marks[j] = marks[j - gap];
                j = j - gap;
            }
            marks[j] = temp;
        }
        if (gap / 2 != 0)
            gap = gap / 2;
        else if (gap == 1)
            gap = 0;
        else
            gap = 1;
    }

    foreach (int mark in marks)
    {
        Console.WriteLine(mark);
    }
}