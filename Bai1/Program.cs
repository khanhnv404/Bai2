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
    }
}
