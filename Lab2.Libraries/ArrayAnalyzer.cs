using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2.Libraries


{
    /// <summary>
    /// Для работы с массивами
    /// </summary>
    public static class ArrayAnalyzer
    {
        /// <summary>
        /// Сгенерировать массив случайных чисел
        /// </summary>
        /// <returns>массив случайных чисел</returns>
        public static int[] GeneratesRandomNumberArray()
        {
            int size = 10; 
            int minValue = 0; 
            int maxValue = 100; 

            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }

            return array;
        }

        /// <summary>
        /// Найти минимальное число в массиве
        /// </summary>
        /// <param name="array">массив чисел</param>
        /// <returns>минимальное число в массиве</returns>
        private static int FindMinimum(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        /// <summary>
        /// Найти маскимальное число в массиве
        /// </summary>
        /// <param name="array">массив чисел</param>
        /// <returns>максимальное число в массиве</returns>
        private static int FindMaximum(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        /// <summary>
        /// Отсортировать по возрастанию (сортировка пузырьком)
        /// </summary>
        /// <param name="array">массив чисел</param>
        /// <exception cref="ArgumentException">массив имеет меньше двух элементов</exception>
        public static void ArraySortAscending(int[] array)
        {
            if (array.Length < 2)
            {
                throw new ArgumentException("Массив должен иметь не меньше двух элементов", nameof(array));
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int t = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = t;
                    }
                }
            }
        }

        /// <summary>
        /// Вывести массив в консоль
        /// </summary>
        /// <param name="array">массив чисел</param>
        public static void PrintArray(int[] array)
        {
            Console.Write("Массив чисел: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }

                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Вывести информацию о массиве
        /// </summary>
        /// <param name="array">массив чисел</param>
        public static void PrintInformation(int[] array)
        {
            PrintArray(array);
            Console.WriteLine("Отсортированный массив");
            ArraySortAscending(array);
            PrintArray(array);
            Console.WriteLine($"Количество элементов: {array.Length}");
            Console.WriteLine($"Минимальный элемент массива: {FindMinimum(array)}");
            Console.WriteLine($"Максимальный элемент массива: {FindMaximum(array)}");
        }
    }
}
