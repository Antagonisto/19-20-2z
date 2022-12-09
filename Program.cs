using static System.Convert;
using static System.Console;

namespace array
{
    class Program
    {
        // точка входа в программу
        static void Main(string[] args)
        {
            // заданная строка
            Write("Введите осмысленное сообщения: ");
            string s = ReadLine();
            Write("Введите символ: ");
            char x = ToChar(ReadLine());
            string p = "Удалены те слова которые заканчиваются на заданный символ {0}: {1}";
            // Удалить из сообщения все слова, которые заканчиваются на заданный символ
            string[] div = s.Split(' ', ',', '.', '-', '!', '?');
            for (int i = 0; i < div.Length; i++)
            {
                if (div[i].EndsWith(x.ToString()))
                {
                    WriteLine(p, x, div[i]);
                }
            }
            ReadKey();
        }
    }
}