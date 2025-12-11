namespace ShareLibrary
{
    /// <summary>
    /// Для анализа текста
    /// </summary>
    public static class TextAnalyzer
    {
        /// <summary>
        /// Поймать ошибку аргумета типа string.
        /// </summary>
        /// <param name="text"></param>
        /// <exception cref="ArgumentException"></exception>
        private static void CatchStringArgumentError(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Аргумент не должен быть пустым", nameof(text));
            }
        }

        /// <summary>
        /// Расчетать среднюю длину слова.
        /// </summary>
        /// <param name="text">текст пользователя</param>
        /// <returns>средняя длина слова в тексте</returns>
        public static double CalculateAverageLengthWord(string text)
        {
            CatchStringArgumentError(text);

            float wordCount = 1;
            float totalLength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsPunctuation(text[i]) || char.IsWhiteSpace(text[i]))
                {
                    continue;
                }

                if (i != text.Length - 1 && (char.IsWhiteSpace(text[i + 1]) || char.IsPunctuation(text[i + 1])))
                {
                    wordCount++;
                }

                totalLength++;
            }
            return totalLength / wordCount;
        }

        /// <summary>
        /// Посчитать количество слов.
        /// </summary>
        /// <param name="text">Строка пользователя.</param>
        public static int CountNumberWords(string text)
        {
            CatchStringArgumentError(text);

            text = text.ToLower().Trim();
            var textElements = text.Split(' ', '.');
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
