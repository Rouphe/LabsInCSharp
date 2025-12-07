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
        /// <param name="text">текст пользователя</param>
        /// <returns>средняя длина слова в тексте</returns>
        public static double AverageWordLengthCounter(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("В вашем тексте нет слов");
            }

            float wordCount =  1;
            float totalLength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsPunctuation(text[i]) || char.IsWhiteSpace(text[i]))
                {
                    continue;
                }

                if (i != text.Length - 1 && (char.IsWhiteSpace(text[i+1]) || char.IsPunctuation(text[i+1])))
                {
                    wordCount++;
                }

                totalLength++;
            }
            return totalLength / wordCount;
        }
    }
}
