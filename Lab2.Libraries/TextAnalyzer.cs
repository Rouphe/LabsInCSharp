namespace Lab2.Libraries


{
    /// <summary>
    /// Класс для анализа текста
    /// </summary>
    public static class TextAnalyzer
    {
        /// <summary>
        /// Расчет средней длины слова в тексте
        /// </summary>
        public static double GetAverageWordLength(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Текст не может быть пустым");

            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '-', '—' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
                return 0;

            double totalLength = 0;
            for (int i = 0; i < words.Length; i++)
            {
                totalLength += words[i].Length;
            }
            return totalLength / words.Length;
        }

        /// <summary>
        /// Вывод анализа текста
        /// </summary>
        public static void PrintAnalysis(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Текст не может быть пустым");
                return;
            }

            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '-', '—' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"Текст: {text}");
            Console.WriteLine($"Количество слов: {words.Length}");
            Console.WriteLine($"Слова: {string.Join(", ", words)}");

            double avgLen = GetAverageWordLength(text);
            Console.WriteLine($"Средняя длина слова: {avgLen:F2}");
        }
    }
}
