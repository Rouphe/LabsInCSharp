using System;
using Lab1.Libraries;

namespace Lab1.App
{
    /// <summary>
    /// Класс для запуска программы
    /// </summary>
    class Program
    {
        /// <summary>
        /// Запускает программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите число для последовательности: ");
            int n = int.Parse(Console.ReadLine());
            string sequence = SequenceGenerator.SequenceCreator(n);
            Console.WriteLine($"Результат: {sequence}");

            Console.Write("Введите нечетное положительное число для квадрата: ");
            int squareSize = int.Parse(Console.ReadLine());
            SquareRenderer.SquareOfStarsPrinter(squareSize);

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}