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

    MergeSort(marks, 0, marks.Length - 1);

    foreach (int mark in marks)
    {
        Console.WriteLine(mark);
    }
}

void MergeSort(int[] arr, int l, int r)
{
    if (l < r)
    {
        int mid = (l + r) / 2;
        MergeSort(arr, l, mid);  //left subarray
        MergeSort(arr, mid + 1, r); //right subarray
        Merge(arr, l, mid, r);
    }
}

void Merge(int[] arr, int l, int m, int r)
{
    int i, j, k;
    int n1 = m - l + 1;
    int n2 = r - m;
    int[] left = new int[n1];
    int[] right = new int[n2];
    for (i = 0; i < n1; i++)
    {
        left[i] = arr[l + i];
    }
    for (j = 0; j < n2; j++)
    {
        right[j] = arr[m + 1 + j];
    }
    i = 0;
    j = 0;
    k = l;
    while (i < n1 && j < n2)
    {
        if (left[i] <= right[j])
        {
            arr[k] = left[i];
            i++;
        }
        else
        {
            arr[k] = right[j];
            j++;
        }
        k++;
    }
    while (i < n1)
    {
        arr[k] = left[i];
        i++;
        k++;
    }
    while (j < n2)
    {
        arr[k] = right[j];
        j++;
        k++;
    }

}