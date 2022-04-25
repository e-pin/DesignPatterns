using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialAlgorithms.Search
{
    public static class BinarySearch
    {
        public static int Search(int[] array, int key)
        {
            // [1, 2, 3, 4]
            //  0  1  2  3
            int min = 0;
            int max = array.Length - 1;

            while(min <= max)
            {
                int mid = (min + max) >> 1;
                if (array[mid] == key) return mid;
                else if (key < array[mid]) max = mid - 1;
                else min = mid + 1;
            }
            return -1;
        }
    }
}
