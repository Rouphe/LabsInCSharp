using System;
using Lab2.Libraries;
using ShareLibrary;

namespace Lab2.App
{
    class Program
    {
        static void Main()
        {
            // Задание 1
            Person person = new Person();

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            double weight;
            double height;

            while (true)
            {


                Console.Write("Введите вес (кг): ");
                string input = Console.ReadLine();


                if (double.TryParse(input, out weight))
                {
                    Console.Write("Введите рост (м): ");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out height))
                    {
                        person.Name = name;
                        person.Weight = weight;
                        person.Height = height;

                        Console.WriteLine(person);

                        double bmi = BMICalculator.Calculate(person);
                        var category = BMICalculator.GetCategory(bmi);

                        switch (category)
                        {
                            case BMICalculator.BmiCategory.NotEnough:
                                Console.WriteLine("Избыточный вес");
                                break;
                            case BMICalculator.BmiCategory.Normal:
                                Console.WriteLine("Нормальный вес");
                                break;
                            case BMICalculator.BmiCategory.Excess:
                                Console.WriteLine("Избыточный вес");
                                break;
                            case BMICalculator.BmiCategory.Fatness:
                                Console.WriteLine("Избыточный вес");
                                break;
                        }

                        Console.WriteLine($"ИМТ (BMI): {bmi:F2}");
                        Console.WriteLine($"Категория: {BMICalculator.GetCategory(bmi)}\n");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: Вы ввели не число! Попробуйте снова.");
                }
            }

            // Задание 2

            int[] arr = ArrayAnalyzer.GeneratesRandomNumberArray();
            ArrayAnalyzer.PrintInformation(arr);
            Console.WriteLine();

            // Задание 3
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();

            double avgLen = TextAnalyzer.CalculateAverageLengthWord(text);
            Console.WriteLine($"\nТекст: {text}");
            Console.WriteLine($"Средняя длина слова: {avgLen:F2}\n");
        }
    }
}