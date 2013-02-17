using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15_SieveOfEratosthenes
{
    class Problem15_SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = 10000000;
            bool[] array = new bool[n];

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (array[i] == false)
                {
                    for (int j = i*i; j < n; j = j + i)
                    {
                        array[j] = true;
                    }
                }
            }

            for (int i = 2; i < n; i++)
            {
                if (array[i] == false)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
