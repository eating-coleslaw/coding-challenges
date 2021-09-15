using System;
using Sorting.MergeSort;
using Sorting.QuickSort;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Merge Sort ====");
            TestTopDownMergeSort();
            
            Console.WriteLine("==== Quick Sort ====");
            TestQuickSort();

            Console.ReadLine();
        }

        public static void TestTopDownMergeSort()
        {
            var test1 = new int[] { 3, 2, -2, 5, -3};
            Console.WriteLine($"{string.Join(", ", test1)} => {string.Join(", ", TopDownMergeSort.Sort(test1))}");
            
            var test2 = new int[] { 1, 3, 2, -4 };
            Console.WriteLine($"{string.Join(", ", test2)} => {string.Join(", ", TopDownMergeSort.Sort(test2))}");
            
            var test3 = new int[] { 10, 80, 30, 90, 40, 50, 70 };
            Console.WriteLine($"{string.Join(", ", test3)} => {string.Join(", ", TopDownMergeSort.Sort(test3))}");
        }

        public static void TestQuickSort()
        {
            var test1 = new int[] { 3, 2, -2, 5, -3 };
            Console.WriteLine($"{string.Join(", ", test1)} => {string.Join(", ", QuickSort.QuickSort.Sort(test1))}");

            var test2 = new int[] { 1, 3, 2, -4 };
            Console.WriteLine($"{string.Join(", ", test2)} => {string.Join(", ", QuickSort.QuickSort.Sort(test2))}");
            
            var test3 = new int[] { 10, 80, 30, 90, 40, 50, 70 };
            Console.WriteLine($"{string.Join(", ", test3)} => {string.Join(", ", QuickSort.QuickSort.Sort(test3))}");
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
