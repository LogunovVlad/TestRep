
namespace WindowsFormsApplication1
{
    class Cesar
    {
        string alphabet;      // Алфавит, заданный пользователем

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="_alphabet">Алфавит шифрования</param>
        public Cesar(string _alphabet)
        {
            alphabet = _alphabet;
        }
        
        /// <summary>
        /// Метод Цезаря шифрование текста
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <param name="position">Количество позиций для сдвига</param>
        /// <returns>Зашифрованный текст</returns>
        public string getEncryption(string text, int position)
        {
            string cipher = "";
            for (int i = 0; i < text.Length; i++)
            {
                cipher += alphabet[(alphabet.IndexOf(text[i]) + position) % alphabet.Length].ToString();
            }
            return cipher;
        }


        public string getDecryption(string cipher, int position)
        {
            string text = "";
            for (int i = 0; i < cipher.Length; i++)
            {
                if (alphabet.IndexOf(cipher[i]) - position < 0)
                {
                    text += alphabet[alphabet.Length - 1 +
                            (alphabet.IndexOf(cipher[i]) - position + 1) % alphabet.Length];
                }
                else
                {
                    text += alphabet[(alphabet.IndexOf(cipher[i]) - position) % alphabet.Length];
                }
            }
            return text;
        }
    }
}
