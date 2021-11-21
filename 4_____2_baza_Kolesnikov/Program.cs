using System;

namespace _4._2_baza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int k = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, k];
            int sum = 0;
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    matrix[i, j] = r.Next(0, 100);
                    Console.Write("{0}\t", matrix[i, j]);
                    sum += matrix[i, j];
                }
                Console.WriteLine();
            }
            Console.Write($"Сумма={sum}");





        }
    }
}
