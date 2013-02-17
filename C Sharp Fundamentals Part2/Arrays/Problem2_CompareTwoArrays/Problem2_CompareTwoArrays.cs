using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_CompareTwoArrays
{
    class Problem2_CompareTwoArrays
    {
        static void Main(string[] args)
        {
            int firstArrayLength = int.Parse(Console.ReadLine());
            int[] firstArray = new int[firstArrayLength];
            
            for (int i = 0; i < firstArrayLength; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());   
            }

            int secondArrayLength = int.Parse(Console.ReadLine());
            int[] secondArray = new int[secondArrayLength];

            for (int i = 0; i < secondArrayLength; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("The arrays are not equal!!!");
                        return;
                    }    
                }
                Console.WriteLine("The arrays are equal!!!");
            }
            else
            {
                Console.WriteLine("The arrays are not equal!!!");
            }
        }
    }
}
