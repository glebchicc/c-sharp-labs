using System;

namespace lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string d = Console.ReadLine();
            string[] words = d.Split(' '); //расщепляет на слова

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", words[i]);
            }
        }
    }
}
