using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem21_GenerateAllCombinationsFrom1ToN
{
    class Problem21_GenerateAllCombinationsFrom1ToN
    {
        static int[,] newArr;

        static void Generate(int index, int n, int k, int[] arr, int start)
        {
            if (index == k)
            {
                Print(arr);
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    arr[index] = i;
                    Generate(index + 1, n, k, arr, i + 1);
                }
            }
        }
        static void Print(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());
            int n = 5;
            int k = 2;
            newArr = new int[n, k];
            int[] arr = new int[k];
            Generate(0, n, k, arr, 1);
        }
    }
}
