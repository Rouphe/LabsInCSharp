using System;
using Lab2.Libraries;

namespace Lab2.App
{
    class Program
    {
        static void Main(string[] args)
        {
         // Демонстрация всех функций
         DemonstrationMode();
        }

        static void DemonstrationMode()
        {
            // Задание 1
            Person person = new Person
            {
                Name = "Иван Иванов",
                Weight = 80,
                Height = 1.85
            };
            Console.WriteLine(person);

            double bmi = BMICalculator.Calculate(person);
            Console.WriteLine($"ИМТ (BMI): {bmi:F2}");
            Console.WriteLine($"Категория: {BMICalculator.GetCategory(bmi)}\n");

            // Задание 2

            int[] arr1 = ArrayAnalyzer.GenerateRandom(10, 1, 100);
            ArrayAnalyzer.PrintStatistics(arr1);

            int[] arr2 = ArrayAnalyzer.GenerateRandom(5, 10, 50);
            ArrayAnalyzer.PrintStatistics(arr2);

            // Задание 3
            string text1 = "The quick brown fox jumps over the lazy dog";
            double avgLen1 = TextAnalyzer.GetAverageWordLength(text1);
            Console.WriteLine($"\nТекст: {text1}");
            Console.WriteLine($"Средняя длина слова: {avgLen1:F2}\n");

            string text2 = "Это сложное предложение с длинными и короткими словами";
            double avgLen2 = TextAnalyzer.GetAverageWordLength(text2);
            Console.WriteLine($"\nТекст: {text2}");
            Console.WriteLine($"Средняя длина слова: {avgLen2:F2}\n");

        }
    }
}