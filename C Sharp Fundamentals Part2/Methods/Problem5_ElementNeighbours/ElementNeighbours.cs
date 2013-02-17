/*
 *Write a method that checks if the element at given position 
 *in given array of integers is bigger than its two neighbors 
 *(when such exist).
 */

using System;

namespace Problem5_ElementNeighbours
{
    class ElementNeighbours
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int positionInArray = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());    
            }

            CompareElement(positionInArray, arr);
            
        }

        static void CompareElement(int positionInArray, int[] arr)
        {
            if (positionInArray > arr.Length - 1 || positionInArray < 0)
            {
                Console.WriteLine("There is no such element in the array!");
            }

            if (positionInArray - 1 == 0)
            {
                if (arr[positionInArray - 1] > arr[positionInArray])
                {
                    Console.WriteLine("The number {0} at position {1} is bigger than his neighbour {2}",
                                    arr[positionInArray - 1], positionInArray, arr[positionInArray]);
                }
                else if (arr[positionInArray - 1] < arr[positionInArray])
                {
                    Console.WriteLine("The number {0} at position {1} is smaller than his neighbour {2}",
                                    arr[positionInArray - 1], positionInArray, arr[positionInArray]);
                }
                else
                {
                    Console.WriteLine("The two numbers are equal!");
                }
            }
            else if (positionInArray == arr.Length - 1)
            {
                if (arr[positionInArray - 1] > arr[positionInArray - 2])
                {
                    Console.WriteLine("The number {0} at position {1} is bigger than his neighbour {2}",
                                    arr[positionInArray - 1], positionInArray, arr[positionInArray]);
                }
                else if (arr[positionInArray - 1] < arr[positionInArray - 2])
                {
                    Console.WriteLine("The number {0} at position {1} is smaller than his neighbour {2}",
                                    arr[positionInArray - 1], positionInArray, arr[positionInArray]);
                }
                else
                {
                    Console.WriteLine("The two numbers are equal!");
                }
            }
            else
            {
                if (arr[positionInArray - 1] > arr[positionInArray] && arr[positionInArray - 1] > arr[positionInArray - 2])
                {
                    Console.WriteLine("The number {0} at position {1} is bigger than its two neighbours {2} and {3}!",
                           arr[positionInArray - 1], positionInArray, arr[positionInArray - 2], arr[positionInArray]);
                }
                else
                {
                    Console.WriteLine("The number {0} at position {1} is not bigger than its two neighbours!");
                }
            }
        }
    }
}
