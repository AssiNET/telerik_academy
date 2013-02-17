using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_ClassMatrix
{
    class Matrix
    {
        private int[,] arr;
        private int row, col;

        //Public Field for accessing matrix width 
        public int Width
        {
            get 
            { 
                return col; 
            }
        }

        //Public field for accesssing matrix height
        public int Height
        {
            get 
            { 
                return row; 
            }
        }

        //Indexer for accessing matrix elements
        public int this[int row, int col]
        {
            get
            {
                return arr[row, col];
            }
            set
            {
                arr[row, col] = value;
            }
        }

        //Constructor for creating matrix object
        public Matrix(int[,] arr)
        {
            this.row = arr.GetLength(0);
            this.col = arr.GetLength(1);

            this.arr = new int[row, col];

            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    this.arr[i, j] = arr[i, j];
                }
            }
        }

        //Overloading operator addition
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Height != m2.Height || m1.Width != m2.Width)
            {
                throw new ArgumentException("The matrices dimensions does not match!!!");
            }

            Matrix sum = new Matrix(new int[m1.Height, m1.Width]);

            for (int i = 0; i < m1.Height; i++)
            {
                for (int j = 0; j < m1.Width; j++)
                {
                    sum[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return sum;
        }

        //Overloading operator subtracting
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Height != m2.Height || m1.Width != m2.Width)
            {
                throw new ArgumentException("The matrices dimensions does not match!!!");
            }

            Matrix difference = new Matrix(new int[m1.Height, m1.Width]);

            for (int i = 0; i < m1.Height; i++)
            {
                for (int j = 0; j < m1.Width; j++)
                {
                    difference[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return difference;
        }

        //Overloading operator multiplication
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Width != m2.Height)
            {
                throw new ArgumentException("The matrices dimensions does not match!!!");
            }

            Matrix product = new Matrix(new int[m1.Height, m2.Width]);

            for (int i = 0; i < m1.Height; i++)
            {
                for (int j = 0; j < m2.Width; j++)
                {
                    for (int k = 0; k < m1.Width; k++)
                    {
                        product[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return product;
        }

        //Overriding method ToString() for printing a matrix
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Height; i++)
            {
                for (int j = 0; j < this.Width; j++)
                {
                    result.AppendFormat("{0, 3}", this[i,j]);
                }
                result.AppendLine("");
            }
            return result.ToString();
        }

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

            Matrix matrix1 = new Matrix(arr1);
            Matrix matrix2 = new Matrix(arr2);
            
            Console.WriteLine(matrix1);
            Console.WriteLine();
            Console.WriteLine(matrix2);

            Console.WriteLine("Addition:\n");
            Matrix result = matrix1 + matrix2;
            Console.WriteLine(result);

            Console.WriteLine("Subtraction:\n");
            Matrix difference = matrix1 - matrix2;
            Console.WriteLine(difference);

            Console.WriteLine("Multiplication:\n");
            Matrix product = matrix1 * matrix2;
            Console.WriteLine(product);
        }
    }
}
