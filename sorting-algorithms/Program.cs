using System;
using Sorting.MergeSort;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TestTopDownMergeSort();

            Console.ReadLine();
        }

        public static void TestTopDownMergeSort()
        {
            var test1 = new int[] { 3, 2, -2, 5, -3};
            Console.WriteLine($"{string.Join(", ", test1)} => {string.Join(", ", TopDownMergeSort.Sort(test1))}");
            
            var test2 = new int[] { 1, 3, 2, -4 };
            Console.WriteLine($"{string.Join(", ", test2)} => {string.Join(", ", TopDownMergeSort.Sort(test2))}");
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
