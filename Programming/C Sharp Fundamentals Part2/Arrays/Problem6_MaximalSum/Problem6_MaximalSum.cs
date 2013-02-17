using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_MaximalSum
{
    class Problem6_MaximalSum
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            int[] array = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            int k = 4;

            int bestSum = 0;
            StringBuilder bestSequence = new StringBuilder();
            
            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                StringBuilder sequence = new StringBuilder();
                for (int j = i; j < k; j++)
                {
                    if (j == array.Length)
                    {
                        break;
                    }
                    sum = sum + array[j];
                    sequence.Append(array[j].ToString() + " ");
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestSequence = sequence;
                    }
                }
                k++;
            }
            Console.WriteLine(bestSum);
            Console.WriteLine(bestSequence);
        }
    }
}