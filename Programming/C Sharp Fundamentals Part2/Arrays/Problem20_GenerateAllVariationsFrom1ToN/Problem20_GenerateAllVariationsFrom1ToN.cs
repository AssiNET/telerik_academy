using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20_GenerateAllVariationsFrom1ToN
{
    class Problem20_GenerateAllVariationsFrom1ToN
    {
        static void Generate(int index, int[] arr, int n, int k)
        {
            if (index == k)
            {
                Print(arr);
            }
            else
            {
                for (int i = 1; i <=n; i++)
                {
                    arr[index] = i;
                    Generate(index + 1, arr, n, k);
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
            int[] arr = new int[k];
            Generate(0, arr, n, k);
        }
    }
}
