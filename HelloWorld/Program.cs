using System;

namespace LearningString
{
    class Program
    {
        static void Main(string[] args)
        {
            // 教程：https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/intro-to-csharp/hello-world

            // 运行首个 C# 程序
            Console.WriteLine("Hello World!");

            // 声明和使用变量
            string aFriend = "Bill";
            Console.WriteLine(aFriend);

            aFriend = "Maria";
            Console.WriteLine(aFriend);

            // 使用字符串
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");

            Console.WriteLine($"The name {aFriend} has {aFriend.Length} letters.");

            // 发掘字符串的更多精彩用途
            string greeting = "       Hello World!         ";
            Console.WriteLine($"[{greeting}]");
            Console.WriteLine($"[{greeting.TrimStart()}]");
            Console.WriteLine($"[{greeting.TrimEnd()}]");

            string trimmedGreeting = greeting.Trim();
            Console.WriteLine($"{trimmedGreeting}");

            trimmedGreeting = trimmedGreeting.Replace("Hello", "Greetings");
            Console.WriteLine($"{trimmedGreeting}");
            Console.WriteLine($"{trimmedGreeting.ToUpper()}");
            Console.WriteLine($"{trimmedGreeting.ToLower()}");

            // 搜索字符串
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
        }
    }
}