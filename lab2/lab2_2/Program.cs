using System;

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            string date1 = now.ToString("G");
            string date2 = now.ToString("F");
            int[] numbers = new int[10];

            Console.WriteLine("Формат даты №1: " + date1);
            Console.WriteLine("Формат даты №2: " + date2);

            for (int i = 0; i < date1.Length; i++)
            {
                if (date1[i] < 58 && date1[i] > 47)
                {
                    numbers[date1[i] - 48]++;
                }
            }

            for (int i = 0; i < date2.Length; i++)
            {
                if (date2[i] < 58 && date2[i] > 47)
                {
                    numbers[date2[i] - 48]++;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Количество " + i + ": " + numbers[i]);
            }
        }
    }
}
