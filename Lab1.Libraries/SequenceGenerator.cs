using System.Text;

namespace Lab1.Libraries
{
    /// <summary>
    /// 
    /// </summary>
    public class SequenceGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
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
                    sb.Append(", ");
            }
            return sb.ToString();
        }
    }
}
