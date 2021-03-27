using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Decider = rnd.Next(0, 15);
            string Theme = "";
            char[] word = new char[] { };
            char[] HiddenWord = new char[] { };
            switch (Decider)
            {
                case 0:
                    word = new char[] { 'b', 's', 'i', 'u', 'r' };
                    HiddenWord = new char[] { '_', '_', '_', '_', '_' };
                    Theme = "belarusian universities";
                    break;

                case 1:
                    word = new char[] { 'b', 's', 'u' };
                    HiddenWord = new char[] { '_', '_', '_' };
                    Theme = "belarusian universities";
                    break;
                case 2:
                    word = new char[] { 'c', 'h', 'e', 's', 's' };
                    HiddenWord = new char[] { '_', '_', '_', '_', '_' };
                    Theme = "sports";
                    break;
                case 3:
                    word = new char[] { 'c', 'a', 'r', 'r', 'o', 't' };
                    HiddenWord = new char[] { '_', '_', '_', '_', '_', '_' };
                    Theme = "vegetables";
                    break;
                case 4:
                    word = new char[] { 'd', 'o', 'g' };
                    HiddenWord = new char[] { '_', '_', '_' };
                    Theme = "animals";
                    break;
                case 5:
                    word = new char[] { 'c', 'a', 't' };
                    HiddenWord = new char[] { '_', '_', '_' };
                    Theme = "animals";
                    break;
                case 6:
                    word = new char[] { 't', 'o', 'm', 'a', 't', 'o' };
                    HiddenWord = new char[] { '_', '_', '_', '_', '_', '_' };
                    Theme = "vegetables";
                    break;
                case 7:
                    word = new char[] { 'p', 'a', 'r', 'r', 'o', 't' };
                    HiddenWord = new char[] { '_', '_', '_', '_', '_', '_' };
                    Theme = "animals";
                    break;
                case 8:
                    word = new char[] { 'p', 'i', 'g' };
                    HiddenWord = new char[] { '_', '_', '_' };
                    Theme = "animals";
                    break;
                case 9:
                    word = new char[] { 'b', 'a', 's', 'k', 'e', 't', 'b', 'a', 'l', 'l' };
                    HiddenWord = new char[] { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' };
                    Theme = "sports";
                    break;
                case 10:
                    word = new char[] { 's', 'o', 'c', 'c', 'e', 'r' };
                    HiddenWord = new char[] { '_', '_', '_', '_', '_', '_' };
                    Theme = "sports";
                    break;
                case 11:
                    word = new char[] { 'h', 'o', 'c', 'k', 'e', 'y' };
                    HiddenWord = new char[] { '_', '_', '_', '_', '_', '_' };
                    Theme = "sports";
                    break;
                case 12:
                    word = new char[] { 'c', 'u', 'c', 'u', 'm', 'b', 'e', 'r' };
                    HiddenWord = new char[] { '_', '_', '_', '_', '_', '_', '_', '_' };
                    Theme = "vegetables";
                    break;
                case 13:
                    word = new char[] { 'b', 'e', 'a', 'r' };
                    HiddenWord = new char[] { '_', '_', '_', '_' };
                    Theme = "animals";
                    break;
                case 14:
                    word = new char[] { 'p', 'a', 'n', 'd', 'a' };
                    HiddenWord = new char[] { '_', '_', '_', '_', '_' };
                    Theme = "animals";
                    break;
                case 15:
                    word = new char[] { 'c', 'a', 'b', 'b', 'a', 'g', 'e' };
                    HiddenWord = new char[] { '_', '_', '_', '_', '_', '_', '_' };
                    Theme = "vegetables";
                    break;

            }
            int j = 0;
            int Death = 0;
            int Luck = 0;
            String Used = "";
            String UsedChar = "";
            char character = ' ';
            Console.Write("Theme is : ");
            Console.WriteLine(Theme);
            Console.WriteLine("The word is \n");
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(HiddenWord[i]);
            }
            Console.WriteLine("\t");

            while (j != word.Length & Death != 8)
            {
                if (Used.Contains(character))
                {
                    while (Used.Contains(character))
                    {
                        Console.WriteLine("Write your character");
                        character = Console.ReadKey().KeyChar;
                        while (character < 97 | character > 122)
                        {
                            Console.WriteLine("Use only lowercase English characters");
                            character = Console.ReadKey().KeyChar;
                        }
                        UsedChar = Convert.ToString(character);
                    }
                    Used += UsedChar;
                }
                else
                {
                    Console.WriteLine("Write your character");
                    character = Console.ReadKey().KeyChar;
                    while (character < 97 | character > 122)
                    {
                        Console.WriteLine("Use only lowercase English characters");
                        character = Console.ReadKey().KeyChar;
                    }

                    UsedChar = Convert.ToString(character);
                    Used += UsedChar;
                }

                Console.Clear();
                Console.Write("Theme is: ");
                Console.WriteLine(Theme);
                Console.WriteLine("The word is \n");
                for (int i = 0; i < word.Length; i++)
                {
                    if (character == word[i])
                    {
                        HiddenWord[i] = character;
                        j++;
                        Luck++;
                    }
                }
                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(HiddenWord[i]);

                }
                Console.WriteLine("\t");
                if (Luck == 0)
                {
                    Death++;
                }
                Luck = 0;
                Console.WriteLine("Used Characters : " + Used);
                switch (Death)
                {
                    case 1:
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine("|");
                        }
                        break;
                    case 2:
                        Console.WriteLine("_______");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine("|");
                        }
                        break;
                    case 3:
                        Console.WriteLine("_______");
                        Console.WriteLine("|      |");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("|");
                        }
                        break;
                    case 4:
                        Console.WriteLine("_______");
                        Console.WriteLine("|      |");
                        Console.WriteLine("|      0");
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine("|");
                        }
                        break;
                    case 5:
                        Console.WriteLine("_______");
                        Console.WriteLine("|      |");
                        Console.WriteLine("|      0");
                        Console.WriteLine("|     /");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("|");
                        }
                        break;
                    case 6:
                        Console.WriteLine("_______");
                        Console.WriteLine("|      |");
                        Console.WriteLine("|      0");
                        Console.WriteLine("|     / \\ ");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("|");
                        }
                        break;
                    case 7:
                        Console.WriteLine("_______");
                        Console.WriteLine("|      |");
                        Console.WriteLine("|      0");
                        Console.WriteLine("|     /|\\ ");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("|");
                        }
                        break;
                }
            }
            if (Death == 8)
            {
                Console.WriteLine("You are dead!\n");

                Console.WriteLine("_______");
                Console.WriteLine("|      |");
                Console.WriteLine("|      0");
                Console.WriteLine("|     /|\\ ");
                Console.WriteLine("|     / \\ ");
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("|");
                }

                Console.Write("The real word was: ");
                for (int k = 0; k < word.Length; k++)
                {
                    Console.Write(word[k]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("CONGRATULATIONS! You won!");
            }
            Console.ReadLine();
        }
    }
}
