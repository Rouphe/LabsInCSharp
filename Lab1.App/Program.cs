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
        static void Main()
        {
            Console.Write("Введите число для последовательности: ");
            int n;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    string sequence = SequenceGenerator.SequenceCreator(n);
                    Console.WriteLine($"Результат: {sequence}");
                    Console.Write("Введите нечетное положительное число для квадрата: ");
                    if (int.TryParse(Console.ReadLine(), out n))
                    {
                        SquareRenderer.SquareOfStarsPrinter(n);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число, попробуйте ещё раз");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не число, попробуйте ещё раз");
                }
            }
        }
    }
}