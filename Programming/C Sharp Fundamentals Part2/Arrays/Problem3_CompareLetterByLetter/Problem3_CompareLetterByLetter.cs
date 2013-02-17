using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_CompareLetterByLetter
{
    class Problem3_CompareLetterByLetter
    {
        static void Main(string[] args)
        {
            char[] arr1 = {'k', 'r', 'a','s', 'm', 'i', 'r' };
            char[] arr2 = {'k', 'r', 'a', 's', 'm', 'i', 'r' };

            int arr1Length = arr1.Length;
            int arr2Length = arr2.Length;

            if (arr1Length < arr2Length)
            {
                for (int i = 0; i < arr1Length; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine("The first array is lexigoraphically before the second array.");
                    }
                    else if (arr2[i] < arr1[i])
                    {
                        Console.WriteLine("The second array is lexicographically before the first array.");
                    }
                    else
                    {
                        Console.WriteLine("The first array is lexicographically before the second array.");
                    }
                    break;
                }
            }
            else if (arr2Length < arr1Length)
            {
                for (int i = 0; i < arr2Length; i++)
                {
                    if (arr2[i] < arr1[i])
                    {
                        Console.WriteLine("The second array is lexigoraphically before the first array.");
                    }
                    else if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine("The first array is lexicographically before the second array.");
                    }
                    else
                    {
                        Console.WriteLine("The second array is lexicographically before the first array.");
                    }
                    break;
                }
            }
            else   
            {
                for (int i = 0; i < arr1Length; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine("The first array is lexigoraphically before the second array.");
                    }
                    else if (arr2[i] < arr1[i])
                    {
                        Console.WriteLine("The second array is lexicographically before the first array.");
                    }
                    else
                    {
                        Console.WriteLine("The the two arrays are lexicographically equal.");
                    }
                    break;
                }
            }
        }
    }
}