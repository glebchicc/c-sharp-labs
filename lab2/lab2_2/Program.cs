using System;

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            string date = now.ToString("d");
            string time = now.ToString("T");
            int[] numbers = new int[10];

            Console.WriteLine("Текущее время: " + time);
            Console.WriteLine("Текущая дата: " + date);

            for (int i = 0; i < date.Length; i++)
            {
                if (date[i] < 58 && date[i] > 47)
                {
                    numbers[date[i] - 48]++;
                }
            }

            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] < 58 && time[i] > 47)
                {
                    numbers[time[i] - 48]++;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Количество " + i + ": " + numbers[i]);
            }
        }
    }
}
