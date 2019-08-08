using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // 教程：https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops

            {
                // 使用 if 语句做出决定
                int a = 5;
                int b = 6;
                if (a + b > 10)
                    Console.WriteLine("The answer is greater than 10.");
            }

            {
                // 让 if 和 else 完美配合
                int a = 5;
                int b = 3;
                int c = 4;
                if ((a + b + c > 10) || (a == b))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("Or the first number is equal to the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("And the first number is not equal to the second");
                }
            }

            {
                // 使用循环重复执行运算
                int counter = 0;
                while (counter < 10)
                {
                    Console.WriteLine($"Hello World! The counter is {counter}");
                    counter++;
                }

                int _counter = 0;
                do
                {
                    Console.WriteLine($"Hello World! The _counter is {_counter}");
                    _counter++;
                } while (_counter < 10);
            }

            {
                // 使用 for 循环
                for (int counter = 0; counter < 10; counter++)
                {
                    Console.WriteLine($"Hello World! The counter is {counter}");
                }
            }

            {
                // 结合使用分支和循环
                int sum = 0;
                for (int counter = 1; counter <= 20; counter++)
                {
                    if (counter % 3 == 0)
                    {
                        sum += counter;
                    }
                }

                Console.WriteLine($"The sum is {sum}");
            }
        }
    }
}