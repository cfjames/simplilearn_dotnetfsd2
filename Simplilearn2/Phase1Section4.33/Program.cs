// See https://aka.ms/new-console-template for more information
using System.Collections;

RunApp();
//Extra Example of using builtin .NET Sorting
//SortExample();

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
    marks[8] = 69;
    marks[9] = 56;

    QuickSort(marks, 0, marks.Length - 1);

    foreach (int mark in marks)
    {
        Console.WriteLine(mark);
    }
}

void QuickSort(int[] arr, int left, int right)
{
    int pivot;
    if (left < right)
    {
        pivot = Partition(arr, left, right);
        if (pivot > 1)
        {
            QuickSort(arr, left, pivot - 1);
        }
        if (pivot + 1 < right)
        {
            QuickSort(arr, pivot + 1, right);
        }
    }
}

int Partition(int[] arr, int left, int right)
{
    int pivot;
    pivot = arr[left];
    while (true)
    {
        while (arr[left] < pivot)
        {
            left++;
        }
        while (arr[right] > pivot)
        {
            right--;
        }
        if (left < right)
        {
            int temp = arr[right];
            arr[right] = arr[left];
            arr[left] = temp;
        }
        else
        {
            return right;
        }
    }
}

void SortExample()
{
    int[] marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };
    Array.Sort(marks);
    marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };
    IComparer myComparer = new myReverserClass();
    Array.Sort(marks, myComparer);
}

public class myReverserClass : IComparer
{

    // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
    int IComparer.Compare(Object x, Object y)
    {
        return ((new CaseInsensitiveComparer()).Compare(y, x));
    }
}

