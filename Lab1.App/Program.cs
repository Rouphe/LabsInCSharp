using System;
using Lab1.Libraries;

namespace Lab1.App
{
    /// <summary>
    /// Для запуска программы
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
                    string sequence = SequenceGenerator.SequenceGenerates(n);
                    Console.WriteLine($"Результат: {sequence}");
                    Console.Write("Введите нечетное положительное число для квадрата: ");
                    if (int.TryParse(Console.ReadLine(), out n))
                    {
                        SquareRenderer.PrintSquareOfStars(n);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(OutputError());
                    }
                }
                else
                {
                    Console.WriteLine(OutputError());
                }
            }
        }

        private static string OutputError()
        {
            return "Вы ввели не число, попробуйте ещё раз";
        }

    }
}