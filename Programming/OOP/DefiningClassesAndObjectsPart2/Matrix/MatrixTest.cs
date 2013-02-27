using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixTest
    {
        static void Main(string[] args)
        {
            int[,] arr1 = 
            {
                { 1, 2 },
                { 3, 4 }
            };

            int[,] arr2 = 
            {
                { 5, 6 },
                { 7, 8 }
            };

            Matrix<int> matrix1 = new Matrix<int>(arr1);
            Matrix<int> matrix2 = new Matrix<int>(arr2);

            Console.WriteLine(matrix1);
            if (matrix1)
            {
                Console.WriteLine("The matrix has zero elements");
            }
            else
            {
                Console.WriteLine("The matrix hasn't zero elements");
            }

            Console.WriteLine();
            
            Console.WriteLine(matrix2);
            if (matrix2)
            {
                Console.WriteLine("The matrix has zero elements");
            }
            else
            {
                Console.WriteLine("The matrix hasn't zero elements");
            }

            Console.WriteLine("\nAddition:\n");
            Matrix<int> result = matrix1 + matrix2;
            Console.WriteLine(result);

            Console.WriteLine("Subtraction:\n");
            Matrix<int> difference = matrix1 - matrix2;
            Console.WriteLine(difference);

            Console.WriteLine("Multiplication:\n");
            Matrix<int> product = matrix1 * matrix2;
            Console.WriteLine(product);
        }
    }
}
