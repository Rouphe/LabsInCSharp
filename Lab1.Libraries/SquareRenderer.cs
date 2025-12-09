using System.Text;

namespace Lab1.Libraries
{
    /// <summary>
    /// Для работы с квадратом из звёзд
    /// </summary>
    public class SquareRenderer
    {
        /// <summary>
        /// Рисует квадрат из звёзд
        /// </summary>
        /// <param name="n">размер стороны квадрата</param>
        /// <exception cref="ArgumentException">Ошибка аргумента "n"</exception>
        public static string PrintSquareOfStars(int n)
        {
            if (n < 1 || n % 2 == 0)
            {
                throw new ArgumentException("Аргумент должен быть нечётным положительным числом", nameof(n));
            }

            int center = n / 2;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var s = (i == center && j == center)
                        ? " "
                        : "*";
                    sb.Append(s);
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
