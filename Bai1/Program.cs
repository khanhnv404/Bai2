using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao kich thuoc ma tran:");
            int size = Convert.ToInt32(Console.ReadLine());

            var matrix = Generate(size);
            PrintMatrix(matrix);
        }

        public static int[,] Generate(int size)
        {
            var random = new Random();
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next();
                }
            }
            return matrix;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // 2. c
        public static int UpperTriangleSum(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < columns; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }

        //2.d
        public static int LowerTriangleSum(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }

        //2e
        public static int BoundariesProduct(int[,] matrix)
        {
            int product = 1;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                product *= matrix[i, 0];
                product *= matrix[i, columns - 1];
            }
            for (int i = 1; i < columns - 1; i++)
            {
                product *= matrix[0, i];
                product *= matrix[rows - 1, i];
            }
            return product;
        }

        //2f
        public static bool IsSymmetric(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            if (rows != columns)
                return false; //if not square, not symmetric

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                        return false;
                }
            }
            return true;
        }
    }
}
