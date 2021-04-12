using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    class Program
    {
        [DllImport("winmm.dll")]
        public static extern bool PlaySound(string sound, IntPtr hmod, uint fdwSound);

        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                Console.Clear();
                Console.WriteLine("Выберите аудиофайл для проигрывания: \n0. Стандартный аудиофайл. \n1. Свой аудиофайл.");
                string pick = Console.ReadLine();
                if (pick == "1")
                {
                    Console.Write("Введите пусть до .wav файла: ");
                    string filename = Console.ReadLine();

                    FileInfo fileInf = new FileInfo(filename);

                    while (!fileInf.Exists)
                    {
                        Console.Write("Не удалось загрузить файл, повторите попытку: ");
                        fileInf = new FileInfo(Console.ReadLine());
                    }

                    filename = fileInf.FullName;

                    Console.WriteLine($"\nСейчас играет: {fileInf.Name}\n");

                    PlaySound(filename, IntPtr.Zero, 0x0001);

                    Console.WriteLine($"Нажмите S, чтобы пропустить аудиофайл: ");

                    while (Console.ReadKey().Key != ConsoleKey.S)
                    {
                        Console.ReadKey();
                    }

                    PlaySound(" ", IntPtr.Zero, 0x0001);

                }
                else if (pick == "0")
                {

                    Console.WriteLine($"\nThe Weekend - Blinding Lights\n");

                    PlaySound("default.wav", IntPtr.Zero, 0x0001);

                    Console.WriteLine($"Нажмите S, чтобы пропустить аудиофайл: ");
                    while (Console.ReadKey().Key != ConsoleKey.S)
                    {
                        Console.ReadKey();
                    }
                    PlaySound(" ", IntPtr.Zero, 0x0001);
                }
            }
        }
    }
}
