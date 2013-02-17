/*
 *Write a program that can solve these tasks:
    -Reverses the digits of a number
    -Calculates the average of a sequence of integers
    -Solves a linear equation a * x + b = 0
		-Create appropriate methods.
		-Provide a simple text-based menu for the user to choose which task to solve.
		-Validate the input data:
 *The decimal number should be non-negative
 *The sequence should not be empty a should not be equal to 0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13_SolvingTasks
{
    class SolvingTasks
    {
        static void Main(string[] args)
        {
            ProgramMenu();
        }

        static void ProgramMenu()
        {
            int option = 0;
            
            Console.WriteLine("----------------Menu----------------\n");
            Console.WriteLine("1. Reverse digits of a number\n");
            Console.WriteLine("2. Calculates the average of a sequence of integers\n");
            Console.WriteLine("3. Solves a linear equation (Example: a * x + b = 0)\n");
            Console.WriteLine("4. Exit.\n");
            Console.Write("Please, pick an option: ");
            option = int.Parse(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                    ReverseDigits();
                    ProgramMenu();
                    break;
                case 2:
                    CalculateAverage();
                    ProgramMenu();
                    break;
                case 3:
                    SolveLinearEquation();
                    ProgramMenu();
                    break;
                case 4:
                    System.Environment.Exit(0);
                    break;
                default:
                    ProgramMenu();
                    break;
            }
        }

        static void SolveLinearEquation()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool validation = isValidEquation(a);
            decimal x = 0;
            if (validation)
            {
                x = (-b / a);
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("a is equal to zero.");
            }
        }

        static bool isValidEquation(int a)
        {
            if (a != 0)
            {
                return true;
            }
            return false;
        }

        static void CalculateAverage()
        {
            int n = int.Parse(Console.ReadLine());
            bool validation = isSequenceValid(n);
            
            if (validation)
            {
                int[] sequence = new int[n];
                for (int i = 0; i < n; i++)
                {
                    sequence[i] = int.Parse(Console.ReadLine());
                }
                int sum = 0;
                foreach (var number in sequence)
                {
                    sum += number;
                }
                sum /= sequence.Length;
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("The sequence is empty");
            }
        }

        static bool isSequenceValid(int n)
        {
            if (n == 0)
            {
                return false;
            }
            return true;
        }

        static void ReverseDigits()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            string[] numberAsString = new string[number.ToString().Length];

            bool validation = isNumberValid(number);

            if (validation)
            {
                for (int i = 0; i < numberAsString.Length; i++)
                {
                    numberAsString[numberAsString.Length - i - 1] += number.ToString()[i]; 
                }
                Console.WriteLine(string.Join("",numberAsString));
            }
            else
            {
                Console.WriteLine("The number must be positive!");
            }
        }

        static bool isNumberValid(decimal number)
        {
            if (number > 0)
            {
                return true;
            }
            return false;
        }
    }
}