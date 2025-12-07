using static System.Runtime.InteropServices.JavaScript.JSType;

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
        /// <returns>массив случайных чисел</returns>
        public static int[] RandomNumberArrayGenerator()
        {
            int size = 10; //размер массива
            int minValue = 0; //минимальное возможное число в массиве
            int maxValue = 100; //максимальное возможное число в массиве

            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }

            return array;
        }

        /// <summary>
        /// Находит минимальное число в массиве
        /// </summary>
        /// <param name="array">массив чисел</param>
        /// <returns>минимальное число в массиве</returns>
        public static int SeekerMinimum(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым", nameof(array));
            }  

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        /// <summary>
        /// Находит маскимальное число в массиве
        /// </summary>
        /// <param name="array">массив чисел</param>
        /// <returns>максимальное число в массиве</returns>
        public static int SeekerMaximum(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым", nameof(array));
            }

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        /// <summary>
        /// Сортировщик по возрастанию (сортировка пузырьком)
        /// </summary>
        /// <param name="array">массив чисел</param>
        /// <exception cref="ArgumentException">массив имеет меньше двух элементов</exception>
        public static void ArraySorter(int[] array)
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
        /// Выводит массив в консоль
        /// </summary>
        /// <param name="array">массив чисел</param>
        public static void PrinterArray(int[] array)
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
        /// Выводит информацию о массиве
        /// </summary>
        /// <param name="array">массив чисел</param>
        public static void PrinterInformation(int[] array)
        {
            PrinterArray(array);
            Console.WriteLine("Отсортированный массив");
            ArraySorter(array);
            PrinterArray(array);
            Console.WriteLine($"Количество элементов: {array.Length}");
            Console.WriteLine($"Минимальный элемент массива: {SeekerMinimum(array)}");
            Console.WriteLine($"Максимальный элемент массива: {SeekerMaximum(array)}");
        }
    }
}
