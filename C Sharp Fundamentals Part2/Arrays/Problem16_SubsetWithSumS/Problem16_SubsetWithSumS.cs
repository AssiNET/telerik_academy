using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16_SubsetWithSumS
{
    class Problem16_SubsetWithSumS
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int numOfSubsets = (int)(Math.Pow(2, n) - 1);
            List<List<int>> sums = new List<List<int>>();
            bool subsetExists = false;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= numOfSubsets; i++)
            {
                int position = n - 1;
                int bitmask = i;
                int sum = 0;
                List<int> numbersInSum = new List<int>();

                while (bitmask > 0)
                {
                    if ((bitmask & 1) == 1)
                    {
                        numbersInSum.Add(numbers[position]);
                        sum += numbers[position];
                    }
                    bitmask >>= 1;
                    position--;
                }

                if (sum == s)
                {
                    subsetExists = true;
                    sums.Add(numbersInSum);
                }
            }

            if (subsetExists)
            {
                foreach (var item in sums)
                {
                    Console.Write("Yes -> ");
                    foreach (var number in item)
                    {
                        Console.Write(number + " ");
                    }
                    Console.WriteLine();
                }
                return;
            }
            Console.WriteLine("There is no such sum.");
        }
    }
}