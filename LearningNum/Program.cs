using System;

namespace LearningNum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 教程：https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/intro-to-csharp/numbers-in-csharp

            {
                // 探索整数数学运算
                int a = 18;
                int b = 6;
                int c = a + b;
                Console.WriteLine(c);
                Console.WriteLine(a - b);
                Console.WriteLine(a * b);
                Console.WriteLine(a / b);
                Console.WriteLine();
            }
            
            {
                // 探索运算顺序
                int a = 18;
                int b = 6;
                int c = a + b;
                int d = (a + b) * c;
                Console.WriteLine(d);

                int e = a * b / c;
                Console.WriteLine(e);
                
                Console.WriteLine();
            }

            {
                // 探索整数运算精度和限值
                int a = 7;
                int b = 4;
                int c = 3;
                int d = (a + b) / c;
                int e = (a + b) % c;
                Console.WriteLine($"quotient: {d}");
                Console.WriteLine($"remainder: {e}");

                int max = int.MaxValue;
                int min = int.MinValue;
                Console.WriteLine($"The range of integers is {min} to {max}");

                int what = max + 3;
                Console.WriteLine($"An example of overflow: {what}");
                
                Console.WriteLine();
            }

            {
                // 使用双精度类型
                double a = 5;
                double b = 4;
                double c = 2;
                double d = (a + b) / c;
                Console.WriteLine(d);

                double max = double.MaxValue;
                double min = double.MinValue;
                Console.WriteLine($"The range of double is {min} to {max}");

                double third = 1.0 / 3.0;
                Console.WriteLine(third);
                
                Console.WriteLine();
            }

            {
                // 使用固定点类型
                decimal min = decimal.MinValue;
                decimal max = decimal.MaxValue;
                Console.WriteLine($"The range of the decimal type is {min} to {max}");

                double a = 1.0;
                double b = 3.0;
                Console.WriteLine(a / b);

                decimal c = 1.0M;
                decimal d = 3.0M;
                Console.WriteLine(c / d);

                double radius = 2.50;
                double erea = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine(erea);
                Console.WriteLine();
            }
        }
    }
}