namespace Crypter
{
    public class Crypto
    {
        string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public string codeDecode(string? word, int key)
        {
            string newWord = "";
            string fullAlphabet = alphabet + alphabet.ToLower();
            int alphabetLength = fullAlphabet.Length;
            foreach (char c in word)
            {
                int index = fullAlphabet.IndexOf(c);
                if (index < 0)
                {
                    newWord += c;
                }
                else
                {
                    char codedLetter = fullAlphabet[(alphabetLength + index + key) % alphabetLength];
                    newWord += codedLetter;
                }
            }
            return newWord;
        }

        public string codeWord(string? original, int key)
        {
            return codeDecode(original, key);   
        }

        public string decodeWord(string? coded, int key)
        {
            return decodeWord(coded, -key);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Crypto crypto = new Crypto();
            Console.Write("Введите фразу для шифрования: ");
            string? wordToCode = Console.ReadLine();
            Console.Write("Введите ключ для шифрования: ");
            int key = int.Parse(s: Console.ReadLine());
            Console.WriteLine($"Результат шифровки: {crypto.codeWord(wordToCode, key)}");

            Console.Write("Введите фразу для расшифрования: ");
            Console.ReadLine();
            string? wordToDecode = Console.ReadLine();
            Console.Write("Введите ключ для расшифрования: ");
            key = int.Parse(s: Console.ReadLine());
            Console.WriteLine($"Результат шифровки: {crypto.codeWord(wordToDecode, key)}");

        }
    }
}
