using System;

namespace lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите клавишу.");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                Console.WriteLine("\b" + key.Key + " клавиша была нажата.");
            }
            while (key.Key != ConsoleKey.Escape); // по нажатию на Escape завершаем цикл
        }
    }
}
