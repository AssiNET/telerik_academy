using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T>
        where T : struct, IComparable<T>, IEquatable<T>, IConvertible, IFormattable
    {
        // Declaring Fields
        private T[,] matrix;
        private int rowNum, colNum;

        // Declaring Properties

        public int RowNum
        {
            get
            {
                return this.rowNum;
            }
        }

        public int ColNum
        {
            get
            {
                return this.colNum;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                matrix[row, col] = value;
            }
        }

        // Constructors

        //Constructor for creating matrix object
        public Matrix(T[,] arr)
        {
            this.rowNum = arr.GetLength(0);
            this.colNum = arr.GetLength(1);

            this.matrix = new T[this.rowNum, this.colNum];

            for (int i = 0; i < this.rowNum; i++)
            {
                for (int j = 0; j < this.colNum; j++)
                {
                    this.matrix[i, j] = arr[i, j];
                }
            }
        }

        //Overloading operator addition
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.RowNum != m2.RowNum || m1.ColNum != m2.ColNum)
            {
                throw new ArgumentException("The matrices dimensions does not match!!!");
            }

            Matrix<T> sum = new Matrix<T>(new T[m1.RowNum, m1.ColNum]);

            for (int i = 0; i < m1.RowNum; i++)
            {
                for (int j = 0; j < m1.ColNum; j++)
                {
                    sum[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                }
            }
            return sum;
        }

        //Overloading operator subtracting
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.RowNum != m2.RowNum || m1.ColNum != m2.ColNum)
            {
                throw new ArgumentException("The matrices dimensions does not match!!!");
            }

            Matrix<T> difference = new Matrix<T>(new T[m1.RowNum, m1.ColNum]);

            for (int i = 0; i < m1.RowNum; i++)
            {
                for (int j = 0; j < m1.ColNum; j++)
                {
                    difference[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                }
            }
            return difference;
        }

        // Overloading operator true
        public static bool operator true(Matrix<T> m)
        {
            if (m == null)
            {
                return false;
            }

            for (int row = 0; row < m.rowNum; row++)
            {
                for (int col = 0; col < m.colNum; col++)
                {
                    if (m[row, col].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Overloading operator false
        public static bool operator false(Matrix<T> m)
        {
            if (m == null)
            {
                return true;
            }

            for (int row = 0; row < m.rowNum; row++)
            {
                for (int col = 0; col < m.colNum; col++)
                {
                    if (!m[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        //Overloading operator multiplication
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.ColNum != m2.RowNum)
            {
                throw new ArgumentException("The matrices dimensions does not match!!!");
            }

            Matrix<T> product = new Matrix<T>(new T[m1.RowNum, m2.ColNum]);

            for (int i = 0; i < m1.RowNum; i++)
            {
                for (int j = 0; j < m2.ColNum; j++)
                {
                    for (int k = 0; k < m1.ColNum; k++)
                    {
                        product[i, j] += (dynamic)m1[i, k] * (dynamic)m2[k, j];
                    }
                }
            }
            return product;
        }

        //Overriding method ToString() for printing a matrix
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.RowNum; i++)
            {
                for (int j = 0; j < this.ColNum; j++)
                {
                    result.AppendFormat("{0, 3}", this[i, j]);
                }
                result.AppendLine("");
            }
            return result.ToString();
        }
    }
}
