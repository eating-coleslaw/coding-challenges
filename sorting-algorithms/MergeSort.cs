using System;

namespace Sorting.MergeSort
{
  public static class TopDownMergeSort
  {
    public static int[] Sort(int[] arr)
    {
      var n = arr.Length;

      if (n == 0)
      {
        return arr;
      }

      var workArr = new int[n];
      arr.CopyTo(workArr, 0);

      TopDownSplitMerge(arr, workArr, 0, n);

      return arr;
    }

    // Split arr into two runs, sort those runs into workArr, then merge both runs back into arr
    private static void TopDownSplitMerge(int[] arr, int[] workArr, int iStart, int iEnd)
    {
      // Split has 1 element 
      if (iEnd - iStart <= 1)
      {
        return;
      }

      var iMiddle = (iEnd + iStart) / 2;
      TopDownSplitMerge(workArr, arr, iStart, iMiddle);
      TopDownSplitMerge(workArr, arr, iMiddle, iEnd);
      
      TopDownMerge(workArr, arr, iStart, iMiddle, iEnd);
    }

    // Sort values in the run from arr into workArr 
    private static void TopDownMerge(int[] arr, int[] workArr, int iStart, int iMiddle, int iEnd)
    {
      var iLeft = iStart;
      var iRight = iMiddle;

      // for each element in the run
      for (var i = iStart; i < iEnd; i++)
      {
        // Choose the lower of the two values at iLeft or iRight
        if (iLeft < iMiddle && (iRight >= iEnd || arr[iLeft] <= arr[iRight]))
        {
          workArr[i] = arr[iLeft];
          iLeft++;
        }
        else
        {
            workArr[i] = arr[iRight];
            iRight++;
        }
      }
    }
  }
}