using System;

namespace lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку. Допустимы русские и английские символы, а также пробел.");
            string s = Console.ReadLine();
            while (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (!(s[i] > 64 && s[i] < 91) && !(s[i] > 96 && s[i] < 123) && !(s[i] > 'А' && s[i] < 'Я') && !(s[i] > 'а' && s[i] < 'я') && s[i] != 'Ё' && s[i] != 'ё' && s[i] != 32)
                {
                    Console.WriteLine("Некорректный ввод");
                    return;
                }
            }
            string[] words = s.Split(' '); //расщепляет на слова

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", words[i]);
            }
        }
    }
}
