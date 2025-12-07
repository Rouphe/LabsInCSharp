namespace Lab2.Libraries


{
    /// <summary>
    /// Структура для хранения информации о человеке
    /// </summary>
    public struct Person
    {
        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Вес в килограммах
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Рост в метрах
        /// </summary>
        public double Height { get; set; }

        public override string ToString()
        {
            return $"Человек: {Name}, Вес: {Weight} кг, Рост: {Height} м";
        }
    }

    /// <summary>
    /// Класс для расчета индекса массы тела (BMI)
    /// </summary>
    public static class BMICalculator
    {
        /// <summary>
        /// Расчет BMI по весу и росту
        /// </summary>
        /// <param name="weight">Вес в килограммах</param>
        /// <param name="height">Рост в метрах</param>
        /// <returns>Значение BMI</returns>
        public static double Calculate(double weight, double height)
        {
            if (height <= 0 || weight <= 0)
                throw new ArgumentException("Вес и рост должны быть положительными числами");

            return weight / (height * height);
        }

        /// <summary>
        /// Расчет BMI для структуры Person
        /// </summary>
        public static double Calculate(Person person)
        {
            return Calculate(person.Weight, person.Height);
        }

        /// <summary>
        /// Определение категории веса по BMI
        /// </summary>
        public static string GetCategory(double bmi)
        {
            return bmi < 18.5 ? "Недостаточный вес" :
                   bmi < 25 ? "Нормальный вес" :
                   bmi < 30 ? "Избыточный вес" : "Ожирение";
        }
    }
}
