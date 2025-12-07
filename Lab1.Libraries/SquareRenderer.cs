namespace Lab1.Libraries
{
    /// <summary>
    /// Класс для работы с квадратом из звёзд
    /// </summary>
    public class SquareRenderer
    {
        /// <summary>
        /// Рисует квадрат из звёз
        /// </summary>
        /// <param name="n">размер стороны квадрата</param>
        /// <exception cref="ArgumentException">Ошибка аргумента "n"</exception>
        public static void SquareOfStarsPrinter(int n)
        {
            if (n < 1 || n % 2 == 0)
            {
                throw new ArgumentException("Введите нечётное положительное число", nameof(n));
            }
            int center = n / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var s = (i == center && j == center)
                        ? " "
                        : "*";
                    Console.Write(s);
                }
                Console.WriteLine();
            }
        }
    }
}
