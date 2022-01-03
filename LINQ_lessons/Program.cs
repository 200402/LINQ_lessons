﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LINQ_lessons
{
    class Program
    {
        static string[] commands = {"Select: определяет проекцию выбранных значений",
            "Where: определяет фильтр выборки",
            "OrderBy: упорядочивает элементы по возрастанию",
            "OrderByDescending: упорядочивает элементы по убыванию",
            "ThenBy: задает дополнительные критерии для упорядочивания элементов возрастанию",
            "ThenByDescending: задает дополнительные критерии для упорядочивания элементов по убыванию",
            "Join: соединяет две коллекции по определенному признаку",
            "GroupBy: группирует элементы по ключу",
            "ToLookup: группирует элементы по ключу, при этом все элементы добавляются в словарь",
            "GroupJoin: выполняет одновременно соединение коллекций и группировку элементов по ключу",
            "Reverse: располагает элементы в обратном порядке",
            "All: определяет, все ли элементы коллекции удовлятворяют определенному условию",
            "Any: определяет, удовлетворяет хотя бы один элемент коллекции определенному условию",
            "Contains: определяет, содержит ли коллекция определенный элемент",
            "Distinct: удаляет дублирующиеся элементы из коллекции",
            "Except: возвращает разность двух коллекцию, то есть те элементы, которые создаются только в одной коллекции",
            "Union: объединяет две однородные коллекции",
            "Intersect: возвращает пересечение двух коллекций, то есть те элементы, которые встречаются в обоих коллекциях",
            "Count: подсчитывает количество элементов коллекции, которые удовлетворяют определенному условию",
            "Sum: подсчитывает сумму числовых значений в коллекции",
            "Average: подсчитывает cреднее значение числовых значений в коллекции",
            "Min: находит минимальное значение",
            "Max: находит максимальное значение",
            "Take: выбирает определенное количество элементов",
            "Skip: пропускает определенное количество элементов",
            "1","2","0","3","5","4","7","789","13","555",
            "а","А","Ф","Ц","Б","в","В","Б","аБв","АБв","абв",
            "TakeWhile: возвращает цепочку элементов последовательности, до тех пор, пока условие истинно",
            "SkipWhile: пропускает элементы в последовательности, пока они удовлетворяют заданному условию, и затем возвращает оставшиеся элементы",
            "Concat: объединяет две коллекции",
            "Zip: объединяет две коллекции в соответствии с определенным условием",
            "First: выбирает первый элемент коллекции",
            "FirstOrDefault: выбирает первый элемент коллекции или возвращает значение по умолчанию",
            "Single: выбирает единственный элемент коллекции, если коллекция содердит больше или меньше одного элемента, то генерируется исключение",
            "SingleOrDefault: выбирает первый элемент коллекции или возвращает значение по умолчанию",
            "ElementAt: выбирает элемент последовательности по определенному индексу",
            "ElementAtOrDefault: выбирает элемент коллекции по определенному индексу или возвращает значение по умолчанию, если индекс вне допустимого диапазона",
            "Last: выбирает последний элемент коллекции",
            "LastOrDefault: выбирает последний элемент коллекции или возвращает значение по умолчанию"};

        static int sleepTime = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите \"е\" для выхода");
            bool shit = true;

            while (shit)
            {
                var s = Console.ReadLine();
                if (s != "e" && s != "е")
                {
                    Console.Clear();
                    LINQSelect();
                    LINQWhere();
                    LINQOrderBy();
                    LINQOrderByDescending();
                    LINQThenBy();
                    LINQThenByDescending();


                    Console.WriteLine("Введите \"е\" для выхода");
                }
                else shit = false;
            }
        }

        static void LINQWhere()
        {
            var sortArray = commands.Where(x => x.Length % 4==0);
            Console.WriteLine("Команда Where");
            Console.WriteLine("Строки в которых кол-во символов кратно 4");
            Console.WriteLine("");
            foreach (var command in sortArray)
            {
                Console.WriteLine(command);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(sleepTime);
        }

        static void LINQSelect()
        {
            var sortArray = commands.Select((x, Index) => $"Индекс строки: {Index + 1}; Длина строки: " + x.Length).Where((x, Index) => (Index + 1) % 4 == 0);
            Console.WriteLine("Команда Select");
            Console.WriteLine("Длина каждой четвертой строки");
            Console.WriteLine("");
            foreach (var command in sortArray)
            {
                Console.WriteLine(command);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(sleepTime);
        }

        static void LINQOrderBy()
        {
            var sortArray = commands.Where((x, Index) => (Index + 1) % 4 == 0)
                .OrderBy(x => x.Length);
            Console.WriteLine("Команда OrderBy");
            Console.WriteLine("Длина каждой четвертой строки, с сортировкой по длине строки");
            Console.WriteLine("");
            foreach (var command in sortArray)
            {
                Console.WriteLine(command);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(sleepTime);
        }

        static void LINQOrderByDescending()
        {
            var sortArray = commands.Where((x, Index) => (Index + 1) % 4 == 0)
                .OrderByDescending(x => x.Length);
            Console.WriteLine("Команда OrderByDescending");
            Console.WriteLine("Длина каждой четвертой строки, с сортировкой по длине строки по убыванию");
            Console.WriteLine("");
            foreach (var command in sortArray)
            {
                Console.WriteLine(command);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(sleepTime);
        }

        static void LINQThenBy()
        {
            var sortArray = commands.OrderByDescending(x => x.Length)
                .ThenBy(x => x.Contains("ключу"));
            Console.WriteLine("Команда ThenBy");
            Console.WriteLine("Сортировка по длине и по слову \"ключу\"");
            Console.WriteLine("");
            foreach (var command in sortArray)
            {
                Console.WriteLine(command);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(sleepTime);
        }

        static void LINQThenByDescending()
        {
            var sortArray = commands.OrderByDescending(x => x.Length)
                .ThenByDescending(x => x.Contains("ключу"));
            Console.WriteLine("Команда ThenBy");
            Console.WriteLine("Сортировка по длине и по слову \"ключу\"");
            Console.WriteLine("");
            foreach (var command in sortArray)
            {
                Console.WriteLine(command);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(sleepTime);
        }
    }
}                                                                                                                                                                 
