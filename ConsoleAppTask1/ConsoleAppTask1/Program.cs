using System;

namespace ConsoleAppTask1
{
    class Program
    {

        static int[,] Build_rand_squere_matrix(int matrix_size)
        {
            int n = matrix_size;

            int[,] matrix = new int[n, n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = rnd.Next(-10, 10);

            return matrix;

        }
        static void Print_2arr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        static void Print_arr(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static int firstNegativeElementLine(int[,] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        static int lastZeroElementLine(int[,] arr)
        {
            int zero = -1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        zero = i;
                    }
                }
            }
            return zero;
        }

        static double DotProduct(int[] v1, int[] v2)
        {
            double result = 0.0;

            if (v1.Length == v2.Length)
                for (int i = 0; i < v1.Length; i++)
                    result += v1[i] * v2[i];

            return result;
        }

        static int[] getLine(int[,] arr, int line_number)
        {
            int[] line = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == line_number)
                    {
                        line[j] = arr[i, j];
                    }
                }
            }
            return line;
        }

        static int[] getColumn(int[,] arr, int column_number)
        {
            int[] column = new int[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == column_number)
                    {
                        column[i] = arr[i, j];
                    }
                }
            }
            return column;

        }

        static void Main(string[] args)
        {
            int[,] arr = Build_rand_squere_matrix(5);
            Print_2arr(arr);
            int negative_line = firstNegativeElementLine(arr);
            int zero_line = lastZeroElementLine(arr);
            Console.WriteLine(negative_line + " " + zero_line);
            Console.Write("Строка");
            Print_arr(getLine(arr, negative_line));
            Console.WriteLine();
            Console.Write("Столбец");
            Print_arr(getColumn(arr, zero_line));
            Console.WriteLine();
            Console.WriteLine("Ответ = " + DotProduct(getLine(arr, negative_line), getColumn(arr, zero_line)));
        }
    }
}
