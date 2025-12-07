using System.Text;

namespace Lab1.Libraries
{
    /// <summary>
    /// Класс для работы с последовательностью
    /// </summary>
    public class SequenceGenerator
    {
        /// <summary>
        /// Генератор последовательности
        /// </summary>
        /// <param name="n">величина последовательности</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">ошибка аргумента "n"</exception>
        public static string SequenceCreator(int n)
        {

            if (n < 1)
            {
                throw new ArgumentException("Аргумент n должен быть положительным.", nameof(n));
            }
            
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                sb.Append(i);
                if (i != n)
                {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }
    }
}
