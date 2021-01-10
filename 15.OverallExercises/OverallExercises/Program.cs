using System;
using System.Linq;
using System.Text;

namespace _65.OverallExercises
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
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                // Минаваме по колоните
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    // Започваме да си пълним матрицата
                    matrix[row, col] = currentRow[col];
                }
            }

            // Отпечатваме броя на редовете
            Console.WriteLine(size[0]);
            
            // Отпечатваме броя на колоните
            Console.WriteLine(matrix.GetLength(1));

            // Отпечатваме сумата на всички елементи
            int sum = 0;
            foreach (var item in matrix)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
