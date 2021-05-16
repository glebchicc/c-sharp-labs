using System;

namespace lab3
{
    abstract class Human
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected string Nationality { get; set; }
        protected int Age { get; set; }
        protected string Sex { get; set; }
        protected double Weight { get; set; }
        protected double Height { get; set; }

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

        public virtual void ShowInfo()
        {
            Console.WriteLine("\nИнформация о человеке:");
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Национальность: " + Nationality);
            Console.WriteLine("Возраст: " + Age);
            if (Sex == "М")
            {
                Console.WriteLine("Пол: мужской");
            }
            else
            {
                Console.WriteLine("Пол: женский");
            }
            Console.WriteLine("Рост в метрах: " + Height);
            Console.WriteLine("Вес в кг: " + Weight);
        }

        public abstract Human SetHuman();
    }

    class Baby : Human
    {
        protected string MotherName { get; set; }
        protected string FatherName { get; set; }

        public Baby(string name, string surname, string nationality, string sex, int age, double weight, double height, string motherName, string fatherName)
        {
            Name = name;
            Surname = surname;
            Nationality = nationality;
            Sex = sex;
            Age = age;
            Weight = weight;
            Height = height;
            MotherName = motherName;
            FatherName = fatherName;
        }

        public Baby()
        {

        }

        public override Baby SetHuman()
        {
            Console.Write("Имя = ");
            string name = Console.ReadLine();
            CheckString(ref name);

            Console.Write("Фамилия = ");
            string surname = Console.ReadLine();
            CheckString(ref surname);

            Console.Write("Национальность = ");
            string nationality = Console.ReadLine();
            CheckString(ref nationality);

            Console.Write("Возраст = ");
            int age = SetForInt(Console.ReadLine());

            Console.Write("Пол (М или Ж) = ");
            string sex = Console.ReadLine();
            CheckSex(ref sex);

            Console.WriteLine("Рост в метрах = ");
            double height = SetForDouble(Console.ReadLine());

            Console.WriteLine("Вес в кг = ");
            double weight = SetForDouble(Console.ReadLine());

            Console.WriteLine("Имя мамы = ");
            string motherName = Console.ReadLine();
            CheckString(ref motherName);

            Console.Write("Имя папы = ");
            string fatherName = Console.ReadLine();
            CheckString(ref motherName);

            Baby baby = new(name, surname, nationality, sex, age, weight, height, motherName, fatherName);
            return baby;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Имя мамы: " + MotherName);
            Console.WriteLine("Имя папы: " + FatherName);
        }
    }

    class Student : Human
    {
        protected string University { get; set; }
        protected int Course { get; set; }

        public Student(string name, string surname, string nationality, string sex, int age, double weight, double height, string university, int course)
        {
            Name = name;
            Surname = surname;
            Nationality = nationality;
            Sex = sex;
            Age = age;
            Weight = weight;
            Height = height;
            University = university;
            Course = course;
        }

        public Student()
        {

        }

        public override Student SetHuman()
        {
            Console.Write("Имя = ");
            string name = Console.ReadLine();
            CheckString(ref name);

            Console.Write("Фамилия = ");
            string surname = Console.ReadLine();
            CheckString(ref surname);

            Console.Write("Национальность = ");
            string nationality = Console.ReadLine();
            CheckString(ref nationality);

            Console.Write("Возраст = ");
            int age = SetForInt(Console.ReadLine());

            Console.Write("Пол (М или Ж) = ");
            string sex = Console.ReadLine();
            CheckSex(ref sex);

            Console.WriteLine("Рост в метрах = ");
            double height = SetForDouble(Console.ReadLine());

            Console.WriteLine("Вес в кг = ");
            double weight = SetForDouble(Console.ReadLine());

            Console.WriteLine("Университет = ");
            string university = Console.ReadLine();
            CheckString(ref university);

            Console.Write("Курс = ");
            int course = SetForInt(Console.ReadLine());

            Student student = new(name, surname, nationality, sex, age, weight, height, university, course);
            return student;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Университет: " + University);
            Console.WriteLine("Курс: " + Course);
        }
    }

    class Worker : Human
    {
        protected string WorkPlace { get; set; }
        protected int Salary { get; set; }

        public Worker(string name, string surname, string nationality, string sex, int age, double weight, double height, string workPlace, int salary)
        {
            Name = name;
            Surname = surname;
            Nationality = nationality;
            Sex = sex;
            Age = age;
            Weight = weight;
            Height = height;
            WorkPlace = workPlace;
            Salary = salary;
        }

        public Worker()
        {

        }

        public override Worker SetHuman()
        {
            Console.Write("Имя = ");
            string name = Console.ReadLine();
            CheckString(ref name);

            Console.Write("Фамилия = ");
            string surname = Console.ReadLine();
            CheckString(ref surname);

            Console.Write("Национальность = ");
            string nationality = Console.ReadLine();
            CheckString(ref nationality);

            Console.Write("Возраст = ");
            int age = SetForInt(Console.ReadLine());

            Console.Write("Пол (М или Ж) = ");
            string sex = Console.ReadLine();
            CheckSex(ref sex);

            Console.WriteLine("Рост в метрах = ");
            double height = SetForDouble(Console.ReadLine());

            Console.WriteLine("Вес в кг = ");
            double weight = SetForDouble(Console.ReadLine());

            Console.WriteLine("Рабочее место = ");
            string workPlace = Console.ReadLine();
            CheckString(ref workPlace);

            Console.Write("Зарплата = ");
            int salary = SetForInt(Console.ReadLine());

            Worker worker = new(name, surname, nationality, sex, age, weight, height, workPlace, salary);
            return worker;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Университет: " + WorkPlace);
            Console.WriteLine("Курс: " + Salary);
        }
    }

    class Pensioner : Human
    {
        protected int Pension { get; set; }
        
        public Pensioner(string name, string surname, string nationality, string sex, int age, double weight, double height, int pension)
        {
            Name = name;
            Surname = surname;
            Nationality = nationality;
            Sex = sex;
            Age = age;
            Weight = weight;
            Height = height;
            Pension = pension;
        }

        public Pensioner()
        {

        }

        public override Pensioner SetHuman()
        {
            Console.Write("Имя = ");
            string name = Console.ReadLine();
            CheckString(ref name);

            Console.Write("Фамилия = ");
            string surname = Console.ReadLine();
            CheckString(ref surname);

            Console.Write("Национальность = ");
            string nationality = Console.ReadLine();
            CheckString(ref nationality);

            Console.Write("Возраст = ");
            int age = SetForInt(Console.ReadLine());

            Console.Write("Пол (М или Ж) = ");
            string sex = Console.ReadLine();
            CheckSex(ref sex);

            Console.WriteLine("Рост в метрах = ");
            double height = SetForDouble(Console.ReadLine());

            Console.WriteLine("Вес в кг = ");
            double weight = SetForDouble(Console.ReadLine());

            Console.Write("Пенсия = ");
            int pension = SetForInt(Console.ReadLine());

            Pensioner pensioner = new(name, surname, nationality, sex, age, weight, height, pension);
            return pensioner;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Пенсия: " + Pension);
        }
    }

    class Program
    {
        static int CheckChoice(string str)
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
                if (str.Length != 1 || !(str[0] >= '0' && str[0] <= '4'))
                {
                    Console.Write("Введите строку и используйте только цифры от 1 до 4 \n");
                    str = Console.ReadLine();
                    check = true;
                }
            } while (check);
            return Convert.ToInt32(str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Является ли человек \n1 - ребенком \n2 - студентом \n3 - рабочим \n4 - пенсионером?");
            int choice = CheckChoice(Console.ReadLine());
            if (choice == 1)
            {
                Baby human = new();
                human = human.SetHuman();
                human.ShowInfo();
            } else if (choice == 2) {
                Student human = new();
                human = human.SetHuman();
                human.ShowInfo();
            } else if (choice == 3)
            {
                Worker human = new();
                human = human.SetHuman();
                human.ShowInfo();
            } else if (choice == 4)
            {
                Pensioner human = new();
                human = human.SetHuman();
                human.ShowInfo();
            }
        }
    }
}
