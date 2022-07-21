using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_2
{
    internal class Matrix
    {
        public static void FillSnake(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int value = 0;

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (j % 2 == 0)
                    {
                        value = j * n + i + 1; ;
                    }
                    else
                    {
                        value = (j + 1) * n - i;
                    }

                    matrix[i, j] = value;
                }
            }
        }
        public static void FillDiagonalSnake(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int i = 0;
            int j = 0;
            matrix[0, 0] = 1;
            matrix[n - 1, n - 1] = n * n;
            bool up = true;

            for (int value = 1; value < n * n; value++)
            {
                if (up)
                    if (i > 0) { i--; j++; }
                    else { j++; up = false; }
                else
                    if (j > 0) { i++; j--; }
                    else { i++; up = true; }
                if (n % 2 == 0 & i == n | n % 2 != 0 & j == n) break;

                matrix[i, j] = value + 1;
                matrix[n - i - 1, n - j - 1] = n * n - value;
            }
        }

        public static void FillSpiralSnake(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            int i = 0;
            int j = 0;

            int nexti = 0;
            int nextj = 0;

            bool turni = true;
            bool changeturn = false;
            int increment = 1;

            matrix[0, 0] = 1;
            for (int value = 1; value < n * m; value++)
            {
                if (turni)
                {
                    i += increment;
                    nexti = i + increment;
                    nextj = j;
                }
                else
                {
                    j += increment;
                    nexti = i;
                    nextj = j + increment;
                }

                if ((nexti == n) | (nextj == m) | (nexti < 0) | (nextj < 0))
                {
                    changeturn = true;
                }
                else
                {
                    if (matrix[nexti, nextj] > 0)
                    {
                        changeturn = true;
                    }
                }

                if (changeturn)
                {
                    changeturn = false;
                    turni = !turni;
                    if ((nextj != j))
                    {
                        increment = -increment;
                    }
                }
                matrix[i, j] = value + 1;
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int n1 = matrix.GetLength(0);
            int n2 = matrix.GetLength(1);
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
