using System;
using System.Linq;

namespace SumColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
               .Split(", ")
               .Select(int.Parse)
               .ToArray();

            // Дефинираме си нашата матрица
            int[,] matrix = new int[size[0], size[1]];

            //Прочитане на матрица
            //Минаваме по реда
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // Прочитаме реда
                int[] currentRow = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                // Минаваме по колоните
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    // Започваме да си пълним матрицата
                    matrix[row, col] = currentRow[col];
                }
            }

            int totalSum = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);

                totalSum += sum;
            }

            Console.WriteLine($"Total sum is: { totalSum}");
        }
    }
}
