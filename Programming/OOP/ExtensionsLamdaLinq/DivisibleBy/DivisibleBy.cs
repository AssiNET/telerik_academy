using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy
{
    class DivisibleBy
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 21, 42 };

            // using Lambda expression
            var numbersLambda = arr.Where(x => (x % 21) == 0);

            foreach (var numLambda in numbersLambda)
            {
                Console.WriteLine(numLambda);
            }

            // using Linq
            var numbersLinq =
                             from num in arr
                             where num % 21 == 0
                             select num;

            foreach (var numLinq in numbersLinq)
            {
                Console.WriteLine(numLinq);
            }
        }
    }
}
