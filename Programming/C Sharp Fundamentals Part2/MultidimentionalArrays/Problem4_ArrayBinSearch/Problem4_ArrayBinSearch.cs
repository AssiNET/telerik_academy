using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_ArrayBinSearch
{
    class Problem4_ArrayBinSearch
    {
        static int BinSearch(int[] arr, int k)
        {
            int result = 0;
            do
            {
                result = Array.BinarySearch(arr, k);
                k--;
            }
            while (result < 0);

            return arr[result];
        }

        static void Main(string[] args)
        {
            //int k = 3;
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int[] arr = { 1, 2, 4, 5, 6 };

            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(arr);

            int number = BinSearch(arr, k);

            Console.WriteLine(number);
        }
    }
}
