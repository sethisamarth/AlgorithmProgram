using System;

namespace InsertionSortProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InsertionSort insertionSort = new InsertionSort();
            int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
            insertionSort.Sort(arr);
            insertionSort.PrintArray(arr);
        }
    }
}
