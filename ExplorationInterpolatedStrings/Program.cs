// 教程：https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/exploration/interpolated-strings

using System;
using System.Collections.Generic;

namespace ExplorationInterpolatedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建内插字符串
            var name = "Geoffrey";
            Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");

            // 包含不同的数据类型
            var item = (Name: "eggplant", Price: 1.99M, perPackage: 3);
            var date = DateTime.Now;
            Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price} per {item.perPackage} items.");

            // 控制内插表达式的格式
            Console.WriteLine(
                $"On {date:d}, the price of {item.Name} was {item.Price:C2} per {item.perPackage} items.");

            // 控制内插表达式的字段宽度和对齐方式
            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, Phillips #2"] = 14
            };

            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine();
            Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
            foreach (var _item in inventory)
            {
                Console.WriteLine($"|{_item.Key,-25}|{_item.Value,10}|");
            }
            
            Console.WriteLine();
            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
        }
    }
}