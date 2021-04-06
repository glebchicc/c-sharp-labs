using System;
using System.Text;

namespace lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < s.Length; i++) //перевод в нижний регистр
            {
                s[i] = char.ToLower(s[i]);
            }
            Console.WriteLine("Рабочая строка: " + s);
            int[] vowels = new int[] { 97, 101, 105, 111, 117, 121}; //коды гласных

            for (int i = 0; i < s.Length; i++) 
            {
                if (!(s[i] > 96 && s[i] < 123)) //проверка ввода
                {
                    Console.WriteLine("Некорректный ввод");
                    return;
                }

                for (int j = 0; j < vowels.Length; j++) //изменение букв
                {
                    if (s[i] == vowels[j] && i < s.Length - 1)
                    {
                        int temp = s[i + 1];
                        if (temp != 122)
                        {
                            temp++;
                            s[i + 1] = Convert.ToChar(temp);
                            break;
                        } else
                        {
                            s = s.Replace(s[i + 1], 'a');
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Готовая строка: " + s);
        }
    }
}
