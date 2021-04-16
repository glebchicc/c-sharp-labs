using System;

namespace lab3
{
    class Human
    {
        protected string name { get; set; }
        protected string surname { get; set; }
        protected string nationality { get; set; }
        protected int age { get; set; }
        protected string sex { get; set; }
        protected double weight { get; set; }
        protected double height { get; set; }

        public Human(string name, string surname, string nationality, string sex, int age, double weight, double height)
        {
            this.name = name;
            this.surname = surname;
            this.nationality = nationality;
            this.sex = sex;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }
        public Human ()
        {

        }

        public static void CheckString(ref string str)
        {
            bool check;
            do
            {
                check = false;
                if (str.Length == 0)
                {
                    Console.Write("Зафиксирована пустая строка\n");
                    str = Console.ReadLine();
                    check = true;
                }
                for (int i = 0; i < str.Length; i++)
                {
                    if (!char.IsLetter(str[i]))
                    {
                        Console.Write("Используйте только символы \n");
                        str = Console.ReadLine();
                        check = true;
                        break;
                    }
                }
            } while (check);
            return;
        }

        public static void CheckSex(ref string str)
        {
            str = str.ToUpper();
            bool check;
            do
            {
                check = false;
                if (str.Length == 0)
                {
                    Console.Write("Зафиксирована пустая строка\n");
                    str = Console.ReadLine();
                    check = true;
                }
                for (int i = 0; i < str.Length; i++)
                {
                    if (!(str == "М" || str == "Ж"))
                    {
                        Console.Write("Используйте 'М' или 'Ж' \n");
                        str = Console.ReadLine();
                        str = str.ToUpper();
                        check = true;
                        break;
                    }
                }
            } while (check);
        }
        public static int SetForInt(string str)
        {
            bool check;
            do
            {
                check = false;
                if (str.Length == 0)
                {
                    Console.Write("Зафиксирована пустая строка\n");
                    str = Console.ReadLine();
                    check = true;
                }
                for (int i = 0; i < str.Length; i++)
                {
                    if (!(str[i] >= '0' && str[i] <= '9'))
                    {
                        Console.Write("Используйте только цифры \n");
                        str = Console.ReadLine();
                        check = true;
                        break;
                    }
                }
            } while (check);
            return Convert.ToInt32(str);
        }

        public static double SetForDouble(string str)
        {
            bool check;
            do
            {
                check = false;
                if (str.Length == 0)
                {
                    Console.Write("Зафиксирована пустая строка\n");
                    str = Console.ReadLine();
                    check = true;
                }
                for (int i = 0; i < str.Length; i++)
                {
                    if (!(str[i] >= '0' && str[i] <= '9') && str[i] != ',') 
                    {
                        Console.Write("Используйте только цифры и запятую \n");
                        str = Console.ReadLine();
                        check = true;
                        break;
                    }
                }
            } while (check);
            return Convert.ToDouble(str);
        }

        public void ShowHuman()
        {
            Console.WriteLine("\nИнформация о человеке:");
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Фамилия: " + surname);
            Console.WriteLine("Национальность: " + nationality);
            Console.WriteLine("Возраст: " + age);
            if (sex == "М")
            {
                Console.WriteLine("Пол: мужской");
            } else
            {
                Console.WriteLine("Пол: женский");
            }
            Console.WriteLine("Рост в метрах: " + height);
            Console.WriteLine("Вес в кг: " + weight);
        }
    }

    class Program
    {
        static Human SetHuman()
        {
            Console.Write("Имя = ");
            string Name = Console.ReadLine();
            Human.CheckString(ref Name);

            Console.Write("Фамилия = ");
            string Surname = Console.ReadLine();
            Human.CheckString(ref Surname);

            Console.Write("Национальность = ");
            string Nationality = Console.ReadLine();
            Human.CheckString(ref Nationality);

            Console.Write("Возраст = ");
            int Age = Human.SetForInt(Console.ReadLine());
            
            Console.Write("Пол (М или Ж) = ");
            string Sex = Console.ReadLine();
            Human.CheckSex(ref Sex);

            Console.WriteLine("Рост в метрах = ");
            double Height = Human.SetForDouble(Console.ReadLine());

            Console.WriteLine("Вес в кг = ");
            double Weight = Human.SetForDouble(Console.ReadLine());

            Human human = new Human(Name, Surname, Nationality, Sex, Age, Weight, Height);
            return human;
        }

        
        static void Main(string[] args)
        {
            Human human = new Human();
            human = SetHuman();
            human.ShowHuman();
        }
    }
}
