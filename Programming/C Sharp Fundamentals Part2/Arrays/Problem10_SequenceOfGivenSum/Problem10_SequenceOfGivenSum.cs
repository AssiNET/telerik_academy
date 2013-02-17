using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10_SequenceOfGivenSum
{
    class Problem10_SequenceOfGivenSum
    {
        static void Main(string[] args)
        {
            int S = 11;
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int currentSum = 0;
            bool sumExists = false;
            //int startIndex = 0;
            //int endIndex = 0;
            StringBuilder sequence = null;

            for (int i = 0; i < array.Length; i++)
            {
                sequence = new StringBuilder();
                for (int j = i; j < array.Length; j++)
                {
                    currentSum = currentSum + array[j];
                    sequence.AppendFormat("{0} ", array[j]);
                    if (currentSum == S)
                    {
                        sumExists = true;
                        //startIndex = i;
                        //endIndex = j;
                        Console.WriteLine(sequence + "-> " + S);
                    }
                    else if (currentSum > S)
                    {
                        currentSum = 0;
                    }
                }
                if (i == array.Length - 1 && !sumExists)
                {
                    Console.WriteLine("There isn't a sum S={0}", S);
                }
            }
        }
    }
}