using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_SelectionSort
{
    class Problem7_SelectionSort
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 2, 4, 5, 8, 7};
            int temp = 0;
            int smallestValue = 0;

            for (int i = 0; i < array.Length; i++)
            {
                smallestValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < smallestValue)
                    {
                        temp = smallestValue;
                        smallestValue = array[j];
                        array[j] = temp;
                    }
                }
                array[i] = smallestValue;
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}