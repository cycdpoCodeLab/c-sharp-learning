using System;
using System.Collections.Generic;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // 创建列表
                var names = new List<string> {"Geoffrey", "Ana", "Felipe"};
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }

                Console.WriteLine();

                // 修改列表内容
                names.Add("Maria");
                names.Add("Bill");
                names.Remove("Ana");

                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }

                Console.WriteLine($"My name is {names[0]}.");
                Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
                Console.WriteLine($"The list has {names.Count} people in it.");
                Console.WriteLine();

                // 搜索列表并进行排序
                var index = names.IndexOf("Felipe");
                if (index != -1)
                {
                    Console.WriteLine($"The name {names[index]} is at index {index}");
                }

                var notFound = names.IndexOf("Not Found");
                Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

                names.Sort();
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}");
                }

                Console.WriteLine();

                // 其他类型的列表
                var fibonacciNumbers = new List<int> {1, 1};
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);

                foreach (var num in fibonacciNumbers)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine();
            }

            {
                // 挑战
                var fibonacciNumbers = new List<int> {1, 1};

                /*
                for (int index = 2; index < 20; index++)
                {
                    fibonacciNumbers.Add(fibonacciNumbers[index - 1] + fibonacciNumbers[index - 2]);
                }
                */

                while (fibonacciNumbers.Count < 20)
                {
                    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                    fibonacciNumbers.Add(previous + previous2);
                }

                foreach (var num in fibonacciNumbers)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}