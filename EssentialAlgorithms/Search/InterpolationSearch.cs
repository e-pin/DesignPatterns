using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialAlgorithms.Search
{
    public static class InterpolationSearch
    {
        public static int Search(int[] array, int key)
        {
            // [1, 2, 3, 4]
            //  0  1  2  3
            // mid = min + (max - min) * (key - array[min] / array[max] - array[min])
            // mid = 0   + (3 - 0) * (3 - 1] / 4 - 1)
            return 0;
        }






































        //public static int Search(int[] array, int key)
        //{
        //    int low = 0;
        //    int high = array.Length - 1;
        //    int mid = 0;

        //    while (low <= high && key >= array[low] && key <= array[high])
        //    {
        //        mid = low + (((key - array[low]) * (high - low)) / (array[high] - array[low]));

        //        if (key < array[mid])
        //        {
        //            high = mid - 1;
        //        }
        //        else if (key > array[mid])
        //        {
        //            low = mid + 1;
        //        }
        //        else
        //        {
        //            return mid;
        //        }
        //    }

        //    return -1;
        //}
    }
}
