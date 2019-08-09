// 教程：https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/string-interpolation

using System;

namespace TutorialsStringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // 介绍
                double a = 3;
                double b = 4;

                Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {.5 * a * b}");
                Console.WriteLine(
                    $"Length of the hypotenuse of the right triangle with {a} and {b} is {CalculateHypotenuse(a, b)}");

                double CalculateHypotenuse(
                    double leg1,
                    double leg2
                ) => Math.Sqrt(
                    Math.Pow(leg1, 2) + Math.Pow(leg2, 2)
                );
            }

            {
                // 如何为内插表达式指定格式字符串
                var date = new DateTime(1731, 11, 25);
                Console.WriteLine(
                    $"On {date:dddd, MMMM dd, yyyy} Leonhard Euler introduced the letter e to denote {Math.E:F5} in a letter to Christian Goldbach.");
            }

            {
                // 如何控制设置了格式的内插表达式的字段宽度和对齐方式
                const int NameAlignment = -9;
                const int ValueAlignment = 7;

                double a = 3;
                double b = 4;
                Console.WriteLine($"Three classical Pythagorean means of {a} and {b}:");
                Console.WriteLine($"|{"Arithmetic",NameAlignment}|{.5 * (a + b),ValueAlignment:F3}|");
                Console.WriteLine($"|{"Geometric",NameAlignment}|{Math.Sqrt(a * b),ValueAlignment:F3}|");
                Console.WriteLine($"|{"Harmonic",NameAlignment}|{2 / (1 / a + 1 / b),ValueAlignment:F3}|");
                Console.WriteLine();
            }

            {
                // 如何在内插字符串中使用转义序列
                var xs = new int[] {1, 2, 7, 9};
                var ys = new int[] {7, 9, 12};
                Console.WriteLine(
                    $"Find the intersection of the {{{string.Join(", ", xs)}}} and {{{string.Join(", ", ys)}}}");

                var userName = "Jane";
                var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
                var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
                Console.WriteLine(stringWithEscapes);
                Console.WriteLine(verbatimInterpolated);
                Console.WriteLine();
            }

            {
                // 如何在内插表达式中使用三元条件运算符 ?:
                var rand = new Random();
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine($"Coin flip: {(rand.NextDouble() < .5 ? "heads" : "rails")}");
                }
                
                Console.WriteLine();
            }

            {
                // 如何使用字符串插值创建区域性特定的结果字符串
                var cultures = new System.Globalization.CultureInfo[]
                {
                    System.Globalization.CultureInfo.GetCultureInfo("en-US"),
                    System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
                    System.Globalization.CultureInfo.GetCultureInfo("nl-NL"),
                    System.Globalization.CultureInfo.GetCultureInfo("zh-CN"),
                    System.Globalization.CultureInfo.InvariantCulture
                };

                var date = DateTime.Now;
                var number = 31_415_926.536;
                FormattableString message = $"{date,20}{number,20:N3}";
                foreach (var culture in cultures)
                {
                    var cultureSpecificMessage = message.ToString(culture);
                    Console.WriteLine($"{culture.Name,-10}{cultureSpecificMessage}");
                }
                Console.WriteLine();
            }

            {
                // 如何使用固定区域性创建结果字符串
                string messageInInvariantCulture =
                    FormattableString.Invariant($"Date and time in invariant culture: {DateTime.Now}");
                Console.WriteLine(messageInInvariantCulture);
            }
        }
    }
}