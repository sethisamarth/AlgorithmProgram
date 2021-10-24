using System;

namespace BubbleSortProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 2, 14, 3, 1, 5, 9 };
            BubbleSort.BubbleSortInArray(arr1);
            BubbleSort.PrintArray(arr1);

        }
    }
}
