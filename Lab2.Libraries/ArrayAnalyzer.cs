namespace Lab2.Libraries


{
    /// <summary>
    /// Класс для работы с массивами
    /// </summary>
    public static class ArrayAnalyzer
    {
        /// <summary>
        /// Генерирует массив случайных чисел
        /// </summary>
        public static int[] GenerateRandom(int size, int minValue = 1, int maxValue = 100)
        {
            if (size <= 0)
                throw new ArgumentException("Размер массива должен быть больше нуля");

            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }

            return array;
        }

        /// <summary>
        /// Поиск минимума
        /// </summary>
        public static int FindMinimum(int[] array)
        {
            if (array.Length == 0)
                return 0;

            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        /// <summary>
        /// Поиск максимума
        /// </summary>
        public static int FindMaximum(int[] array)
        {
            if (array.Length == 0)
                return 0;

            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        /// <summary>
        /// Расчет суммы элементов
        /// </summary>
        public static long CalculateSum(int[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        /// <summary>
        /// Расчет среднего значения
        /// </summary>
        public static double CalculateAverage(int[] array)
        {
            if (array.Length == 0)
                return 0;

            long sum = CalculateSum(array);
            return (double)sum / array.Length;
        }

        /// <summary>
        /// Вывод статистики по массиву
        /// </summary>
        public static void PrintStatistics(int[] array, string title = "Массив")
        {
            Console.WriteLine($"\n{title}:");

            Console.Write("Элементы: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0) Console.Write(", ");
                Console.Write(array[i]);
            }
            Console.WriteLine();

            Console.WriteLine($"Количество элементов: {array.Length}");
            Console.WriteLine($"Минимальное значение: {FindMinimum(array)}");
            Console.WriteLine($"Максимальное значение: {FindMaximum(array)}");
            Console.WriteLine($"Сумма всех элементов: {CalculateSum(array)}");
            Console.WriteLine($"Среднее значение: {CalculateAverage(array):F2}");
        }
    }
}
