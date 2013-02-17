/*
 *Write a method that adds two polynomials. Represent them 
 *as arrays of their coefficients as in the example below:
		x*x + 5 = 1*(x*x) + 0*x + 5 -> 501
 */

using System;
using System.Collections.Generic;

namespace Problem11_12_Polynomials
{
    class Polynomials
    {
        static void Main(string[] args)
        {
            int polinomialExponent = int.Parse(Console.ReadLine());                                // The exponent of the polinomial
            int[] firstPolinomial = new int[polinomialExponent];
            for (int i = 0; i < polinomialExponent; i++)
            {
                firstPolinomial[firstPolinomial.Length - i - 1] = int.Parse(Console.ReadLine());
            }
            Print(firstPolinomial);

            polinomialExponent = int.Parse(Console.ReadLine());                                    // The exponent of the polinomial
            int[] secondPolinomial = new int[polinomialExponent];
            for (int i = 0; i < polinomialExponent; i++)
            {
                secondPolinomial[secondPolinomial.Length - i - 1] = int.Parse(Console.ReadLine());
            }
            Print(secondPolinomial);

            Console.Write("The sum of the two polinomials: ");
            Sum(firstPolinomial, secondPolinomial);

            Console.Write("The product of the two polinomials: ");
            Multiply(firstPolinomial, secondPolinomial);

            Console.Write("The difference of the two polinomials: ");
            Substraction(firstPolinomial, secondPolinomial);
        }

        static void Substraction(int[] firstPolinomial, int[] secondPolinomial)
        {
            List<int> difference = new List<int>(Math.Max(firstPolinomial.Length, secondPolinomial.Length));

            for (int index = 0; index < difference.Capacity; index++)
            {
                int digit = (index < firstPolinomial.Length ? firstPolinomial[index] : 0) - (index < secondPolinomial.Length ? secondPolinomial[index] : 0);
                difference.Add(digit);
            }

            Print(difference.ToArray());
        }

        static void Multiply(int[] firstPolinomial, int[] secondPolinomial)
        {
            int[] product = new int[firstPolinomial.Length + secondPolinomial.Length - 1];

            for (int i = 0; i < firstPolinomial.Length; i++)
            {
                for (int j = 0; j < secondPolinomial.Length; j++)
                {
                    int productIndex = i + j;
                    product[productIndex] += firstPolinomial[i] * secondPolinomial[j];
                }
            }

            Print(product);
        }

        static void Sum(int[] firstPolinomial, int[] secondPolinomial)
        {
            List<int> sum = new List<int>(Math.Max(firstPolinomial.Length, secondPolinomial.Length));

            for (int index = 0; index < sum.Capacity; index++)
            {
                int digit = (index < firstPolinomial.Length ? firstPolinomial[index] : 0) + (index < secondPolinomial.Length ? secondPolinomial[index] : 0);
                sum.Add(digit);
            }

            Print(sum.ToArray());
        }

        static void Print(int[] arr)
        {
            for (int index = arr.Length - 1; index >= 0; index--)
            {
                Console.Write((index != 0 ? (index != 1 ? arr[index].ToString() + "*x^" + index + " + " : arr[index].ToString() + "*x" + " + ")
                                          : arr[index].ToString()));
            }
            Console.WriteLine();
        }
    }
}