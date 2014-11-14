using System;
using LazySingletonDemo.Classes;
using LazySingletonDemo.Classes.Demos;
using LazySingletonDemo.Classes.Repositories;

namespace LazySingletonDemo
{
    class Program
    {

        private static void WriteTitle(string title, bool clear = false)
        {
            if (clear) 
                Console.Clear();
            else
                Console.WriteLine();
            Console.WriteLine("************* {0} *************", title);
            Console.WriteLine();
        }

        private static void PresAnyKey()
        {
            Console.WriteLine();
            Console.Write("Press any key...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            // SINGLETON DEMO
            Console.Clear();

            WriteTitle("NO SINGLETON DEMO");
            new CountryDemo(new NoSingletonRepo()).Run();
            new LanguageDemo(new NoSingletonRepo()).Run();
            PresAnyKey();

            Console.Clear();

            WriteTitle("SINGLETON DEMO");
            new CountryDemo(SingletonRepo.Instance).Run();
            new LanguageDemo(SingletonRepo.Instance).Run();
            PresAnyKey();

            // LAZY SINGLETON DEMO
            Console.Clear();

            WriteTitle("LAZY SINGLETON DEMO");
            new CountryDemo(LazySingletonRepo.Instance).Run();
            new LanguageDemo(LazySingletonRepo.Instance).Run();
            PresAnyKey();

            Console.WriteLine("<<< Program.Main");
        }
    }
}
