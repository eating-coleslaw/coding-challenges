using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.QuickSort
{
    public class QuickSort
    {
        public static int[] Sort(int[] arr)
        {
            var n = arr.Length;
            
            return SortPartition(arr, 0, n - 1);
        }

        private static int[] SortPartition(int[] arr, int iStart, int iEnd)
        {
            if (iStart < iEnd)
            {
                var iPartition = Partition(arr, iStart, iEnd);

                SortPartition(arr, iStart, iPartition - 1);
                SortPartition(arr, iPartition + 1, iEnd);
            }

            return arr;
        }

        private static int Partition(int[] arr, int iStart, int iEnd)
        {
            var pivot = arr[iEnd];
            var iSmaller = iStart - 1;

            for (var i = iStart; i < iEnd; i++)
            {
                if (arr[i] < pivot)
                {
                    iSmaller++;
                    Swap(arr, iSmaller, i);
                }
            }

            Swap(arr, iSmaller + 1, iEnd);
            return (iSmaller + 1);
        }

        private static void Swap(int[] arr, int iA, int iB)
        {
            var temp = arr[iA];
            arr[iA] = arr[iB];
            arr[iB] = temp;
        }
    }
}
