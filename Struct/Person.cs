namespace Struct
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
}
