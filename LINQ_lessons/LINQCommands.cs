using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ_lessons
{
    class LINQCommands
    {
        int sleepTime = 1000;

        public LINQCommands(List<object> lines)
        {
            Console.Clear();
            Console.WriteLine("Исходный массив:");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            LINQSelect(lines);
            LINQWhere(lines);
            LINQOrderBy(lines);
            LINQOrderByDescending(lines);
            LINQThenBy(lines);
            LINQThenByDescending(lines);
            LINQGroupBy(lines);
        }

        private void ConsoleWriter(string header, IEnumerable<object> sortArray)
        {
            Console.WriteLine(header);
            foreach (var line in sortArray)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(sleepTime);
        }

        void LINQSelect(List<object> lines)
        {
            var sortArray = lines.Select((x, Index) => $"Индекс строки: {Index + 1}; Длина строки: " + x.ToString().Length).Where((x, Index) => (Index + 1) % 4 == 0);
            string header = "Команда Select\r\nДлина каждой четвертой строки\r\n";
            ConsoleWriter(header, sortArray);
        }

        void LINQWhere(List<object> lines)
        {
            var sortArray = lines.Where(x => (x.ToString().Length % 2 == 0));
            string header = "команда where\r\nстроки в которых кол-во символов кратно 2\r\n";
            ConsoleWriter(header, sortArray);
        }

        void LINQOrderBy(List<object> lines)
        {
            var sortArray = lines.Where((x, index) => (index + 1) % 4 == 0)
                .OrderBy(x => x.ToString().Length);
            string header = "команда orderby\r\nдлина каждой четвертой строки, с сортировкой по длине строки\r\n";
            ConsoleWriter(header, sortArray);
        }

        void LINQOrderByDescending(List<object> lines)
        {
            var sortArray = lines.Where((x, index) => (index + 1) % 4 == 0)
                .OrderByDescending(x => x.ToString().Length);
            string header = "команда orderbydescending\r\nдлина каждой четвертой строки, с сортировкой по длине строки по убыванию\r\n";
            ConsoleWriter(header, sortArray);
        }

        void LINQThenBy(List<object> lines)
        {
            var sortArray = lines.OrderByDescending(x => x.ToString().Length)
                .ThenBy(x => x.ToString().Contains("ключу"));
            string header = "команда thenby\r\nсортировка по длине и по слову \"ключу\"\r\n";
            ConsoleWriter(header, sortArray);
        }

        void LINQThenByDescending(List<object> lines)
        {
            var sortArray = lines.OrderByDescending(x => x.ToString().Length)
                .ThenByDescending(x => x.ToString().Contains("ключу"));
            string header = "команда thenbydescending\r\nсортировка по длине и по слову \"ключу\"\r\n";
            ConsoleWriter(header, sortArray);
        }

        void LINQGroupBy(List<object> lines)
        {
            var sortArray = lines.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);
            string header = "Команда GroupBy\r\nСортировка по длине и по слову \"ключу\"\r\n";
            ConsoleWriter(header, sortArray);
        }
    }
}
