// 教程：https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/exploration/interpolated-strings-local

using System;

namespace ExplorationInterpolatedStringsLocal
{
    class Vegetable
    {
        // 包含不同的数据类型
        public Vegetable(string name) => Name = name;

        public string Name { get; }

        public override string ToString() => Name;
    }

    class Program
    {
        public enum Unit
        {
            item,
            kilogram,
            gram,
            dozen
        }

        static void Main(string[] args)
        {
            var name = "Geoffrey";
            Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");

            var item = new Vegetable("eggplant");
            var date = DateTime.Now;
            var price = 1.99M;
            var unit = Unit.item;

            Console.WriteLine($"On {date}, the price of {item} was {price} per {unit}.");
            Console.WriteLine($"On {date:d}, the price of {item} was {price:C2} per {unit}.");
        }
    }
}