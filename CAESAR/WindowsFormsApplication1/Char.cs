
namespace WindowsFormsApplication1
{
    /// <summary>
    /// Статический класс, предоставляющий методы 
    /// для получения различных алфавитов
    /// </summary>
    static class Char
    {
        static string alphabet;

        /// <summary>
        /// Заглавные буквы английского алфавита
        /// </summary>
        public static string EnglishSmallishBig
        {
            get
            {
                alphabet = "";
                for (char ch = 'A'; ch <= 'Z'; ch++)
                {
                    alphabet += ch.ToString();
                }
                return alphabet;
            }
        }

        /// <summary>
        /// Строчные буквы английского алфавита
        /// </summary>
        public static string EnglishSmall
        {
            get
            {
                alphabet = "";
                for (char ch = 'a'; ch <= 'z'; ch++)
                {
                    alphabet += ch.ToString();
                }
                return alphabet;
            }
        }

        /// <summary>
        /// Заглавные буквы русского алфавита
        /// </summary>
        public static string RussianBig
        {
            get
            {
                alphabet = "";
                for (char ch = 'А'; ch <= 'Я'; ch++)
                {
                    alphabet += ch.ToString();
                }
                return alphabet;
            }
        }

        /// <summary>
        /// Строчные буквы русского алфавита
        /// </summary>
        public static string RussianSmall
        {
            get
            {
                alphabet = "";
                for (char ch = 'а'; ch <= 'я'; ch++)
                {
                    alphabet += ch.ToString();
                }
                return alphabet;
            }
        }

        /// <summary>
        /// Числа
        /// </summary>
        public static string Numbers
        {
            get
            {
                alphabet = "";
                for (char ch = '0'; ch <= '9'; ch++)
                {
                    alphabet += ch.ToString();
                }
                return alphabet;
            }
        }

        /// <summary>
        /// Скобки и знаки препинания
        /// </summary>
        public static string SpecialCharacters
        {
            get
            {
                alphabet = "";
                for (char ch = ' '; ch <= '/'; ch++)
                {
                    alphabet += ch.ToString();
                }
                for (char ch = ':'; ch <= '?'; ch++)
                {
                    alphabet += ch.ToString();
                }
                return alphabet;
            }
        }

        /// <summary>
        /// Все доступные символы
        /// </summary>
        public static string AllChar
        { 
            get
            {
                alphabet = "";
                alphabet+=RussianSmall;
                alphabet+=RussianBig;
                alphabet+=EnglishSmall;
                alphabet+=EnglishSmallishBig;
                alphabet+=Numbers;
                alphabet+=SpecialCharacters;
                return alphabet;
            }
        }
    }
}
