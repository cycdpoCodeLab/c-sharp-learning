// 教程：https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/exploration/csharp-6

using System;
using System.Collections.Generic;
using System.Linq;

namespace ExplorationCsharp6
{
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string MiddleName { get; } = "";

        public Person(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }

        public override string ToString() => $"{FirstName} {LastName}";

        public string AllCaps() => ToString().ToUpper();
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("Bill", "", "Wagner");
            Console.WriteLine($"The name, in all caps: {p.AllCaps()}");
            Console.WriteLine($"The name: {p}");

            var phrase = "the quick brown fox jumps over the lazy dog";
            var wordLength = from word in phrase.Split(" ") select word.Length;
            // var average = wordLength.Average();
            Console.WriteLine($"The average word length is: {wordLength.Average():F2}");

            // 快速且简单的 null 检查
            string s = null;
            Console.WriteLine(s?.Length);

            char? c = s?[0];
            Console.WriteLine(c.HasValue);

            bool? hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
            Console.WriteLine(hasMore);

            // 异常筛选器
            try
            {
                Console.WriteLine(s.Length);
            }
            catch (Exception e) when (LogException(e))
            {
            }

            Console.WriteLine("Exception must have been handled");

            // 使用 nameof
            Console.WriteLine(nameof(System.String));
            int j = 5;
            Console.WriteLine(nameof(j));
            List<string> names = new List<string>();
            Console.WriteLine(nameof(names));
            
            // 新的对象初始化语法
            var messages = new Dictionary<int, string>
            {
                [404] = "Page not Found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };
            Console.WriteLine(messages[302]);
        }

        private static bool LogException(Exception e)
        {
            Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
            Console.WriteLine($"\tMessage: {e.Message}");
            return true;
        }
    }
}