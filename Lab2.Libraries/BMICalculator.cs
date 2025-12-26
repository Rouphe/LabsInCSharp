namespace Lab2.Libraries


{
    /// <summary>
    /// Структура для хранения информации о человеке
    /// </summary>
    public struct Person
    {
        private double _weight;
        private double _height;
        private string _name;

        /// <summary>
        /// Имя человека
        /// </summary>  
        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(Name));
        }

        /// <summary>
        /// Вес в килограммах
        /// </summary>
        public double Weight
        {
            get => _weight;
            set
            {
                _weight = value > 0
                    ? value
                    : throw new ArgumentException("Вес должен быть больше 0", nameof(Weight));
            }
        }

        /// <summary>
        /// Рост в метрах
        /// </summary>
        public double Height
        {
            get => _height;
            set
            {
                _height = value > 0
                    ? value
                    : throw new ArgumentException("Рост должен быть больше 0", nameof(Height));
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="weight">вес в килограммах</param>
        /// <param name="height">рост в метрах</param>
        public Person(string name, double weight, double height)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }
        
        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        /// <returns>информация о человеке</returns>
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
        /// <param name="person">структура с данными о человеке</param>
        /// <returns>Значение BMI</returns>
        public static double Calculate(Person person)
        {
            return person.Weight / (person.Height * person.Height);
        }

        /// <summary>
        /// Определение категории веса по BMI
        /// </summary>
        public static string GetCategoryString(double bmi)
        {
            return bmi < 18.5 ? "Недостаточный вес" :
                   bmi < 25 ? "Нормальный вес" :
                   bmi < 30 ? "Избыточный вес" : "Ожирение";
        }

        /// <summary>
        /// Классификация BMI
        /// </summary>
        public enum BmiCategory
        {
            /// <summary>
            /// Недостаточный вес
            /// </summary>
            NotEnough = 0,
            
            /// <summary>
            /// Нормальный вес
            /// </summary>
            Normal = 1,

            /// <summary>
            /// Избыточный вес
            /// </summary>
            Excess = 2,

            /// <summary>
            /// Ожирение
            /// </summary>
            Fatness = 3
        }

        public static BmiCategory GetCategory(double bmi)
        {
            switch (bmi)
            {
                case double n when n < 18.5:
                    return BmiCategory.NotEnough;
                case double n when n < 25:
                    return BmiCategory.Normal;
                case double n when n < 30:
                    return BmiCategory.Excess;
                case double n when n > 30:
                    return BmiCategory.Fatness;
                default:
                    throw new ArgumentException("Аргумент должен быть числом");
            }
            
        }

    }
}
