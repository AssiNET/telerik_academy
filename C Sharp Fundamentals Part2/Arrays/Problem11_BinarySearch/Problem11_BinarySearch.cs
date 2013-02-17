using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11_BinarySearch
{
    class Problem11_BinarySearch
    {
        static void Main(string[] args)
        {
            int key = 2;
            int[] array = { 1, 2, 3, 5, 6, 4, 9, 8 };
            Array.Sort(array);

            int leftSide = 0;
            int rightSide = array.Length - 1;

            while (leftSide < rightSide)
            {
                int middle = (leftSide + rightSide) / 2;
                if (key > array[middle])
                {
                    leftSide = middle + 1;
                }
                else
                {
                    rightSide = middle;
                }
            }

            if ((leftSide == rightSide) && (array[leftSide] == key))
            {
                Console.WriteLine("key={0}, index={1}", array[leftSide], leftSide);
            }
            else
            {
                Console.WriteLine("There is no such key in the array.");
            }
        }
    }
}
