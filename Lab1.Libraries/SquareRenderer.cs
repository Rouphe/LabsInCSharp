namespace Lab1.Libraries
{
    /// <summary>
    /// 
    /// </summary>
    public class SquareRenderer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        public static void SquareOfStarsPrinter(int n)
        {
            if (n < 1 || n % 2 == 0)
            {
                Console.WriteLine("Введите нечетное положительное число");
                return;
            }
            int center = n / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var s = (i == center && j == center)
                        ? " "
                        : "*";
                }
                Console.WriteLine();
            }
        }
    }
}
