using System;
using System.Linq;
using System.Collections.Generic;

namespace DataTypesTask
{
    class Program
    {
        // Task 1: BMI Calculator Function (консольная утилита)
        static double CalculateBMI(double weightKg, double heightM)
        {
            if (heightM <= 0 || weightKg <= 0)
            {
                throw new ArgumentException("Вес и рост должны быть положительными числами");
            }

            return weightKg / (heightM * heightM);
        }

        static void DisplayBMICategory(double bmi)
        {
            Console.WriteLine($"\nВаш индекс массы тела (ИМТ): {bmi:F2}");

            if (bmi < 18.5)
            {
                Console.WriteLine("Категория: Недостаточный вес");
            }
            else if (bmi < 25)
                Console.WriteLine("Категория: Нормальный вес");
            else if (bmi < 30)
                Console.WriteLine("Категория: Избыточный вес");
            else
                Console.WriteLine("Категория: Ожирение");
        }
    }
}