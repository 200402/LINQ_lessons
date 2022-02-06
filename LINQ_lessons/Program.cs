using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LINQ_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            arraysForExamples arraysE = new();

            while (true)
            {
                Console.WriteLine("Введите \"Esc\" для выхода или другую клавишу для продолжения");
                var key = Console.ReadKey();
                if (key.Key != ConsoleKey.Escape)
                {
                    LINQCommands example = new(arraysE.number);
                }
                else { Environment.Exit(0); }
            }
        }
    }
}                                                                                                                                                                 
