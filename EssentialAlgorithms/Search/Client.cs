using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialAlgorithms.Search
{
    public static class Client
    {
        public static void Demo()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("***Testing Binary Searh***");
            Console.WriteLine(String.Format("Should return 0, returned {0}", BinarySearch.Search(numbers, 1)));
            Console.WriteLine(String.Format("Should return 2, returned {0}", BinarySearch.Search(numbers, 3)));
            Console.WriteLine(String.Format("Should return 4, returned {0}", BinarySearch.Search(numbers, 5)));
            Console.WriteLine(String.Format("Should return -1, returned {0}", BinarySearch.Search(numbers, 7)));
            Console.WriteLine("***End Binary Search Test***");

        }
    }
}
