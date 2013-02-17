using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem19_GenerateAllPermutationsFrom1ToN
{
    class Problem19_GenerateAllPermutationsFrom1ToN
    {
        static void Generate(int index, int[] arr, int n, bool[] used)
        {
            if (index >= n)
            {
                Print(arr);
            }
            else
            {
                for (int i = 1; i <=n; i++)
                {
                    if (used[i] == false)
                    {
                        used[i] = true;
                        arr[index] = i;
                        Generate(index + 1, arr, n, used);
                        used[i] = false;
                    }
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

        static long CountFactorial(int n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            int n = 5;
            int[] arr = new int[n];
            bool[] used = new bool[CountFactorial(n) + 1];
            Generate(0, arr, n, used);
        }
    }
}
