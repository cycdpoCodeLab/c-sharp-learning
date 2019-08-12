// tutorial: https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/inheritance

using System;
using System.Reflection;
using static System.Console;

namespace TutorialsInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new A1.B();
            WriteLine(b1.GetValue());
            WriteLine();

            B2 b2 = new B2();
            b2.Method();
            WriteLine();

            B3 b3 = new B3();
            b3.Method();
            WriteLine();

            // 隐式继承
            Type t = typeof(SimpleClass);
            BindingFlags flags = BindingFlags.Instance |
                                 BindingFlags.Static |
                                 BindingFlags.Public |
                                 BindingFlags.NonPublic |
                                 BindingFlags.FlattenHierarchy;
            MemberInfo[] members = t.GetMembers(flags);
            WriteLine($"Type {t.Name} has {members.Length} members: ");
            foreach (var member in members)
            {
                string access = "";
                string stat = "";
                var method = member as MethodBase;
                if (method != null)
                {
                    if (method.IsPublic)
                    {
                        access = "Public";
                    }
                    else if (method.IsPrivate)
                    {
                        access = "Private";
                    }
                    else if (method.IsFamily)
                    {
                        access = "Protected";
                    }
                    else if (method.IsAssembly)
                    {
                        access = "Internal";
                    }
                    else if (method.IsFamilyAndAssembly)
                    {
                        access = "Protected Internal";
                    }

                    if (method.IsStatic)
                    {
                        stat = " Static";
                    }
                }

                var output = $"{member.Name} ({member.MemberType}): {access}{stat}, Declared by {member.DeclaringType}";
                Console.WriteLine(output);
            }

            WriteLine();

            SimpleClass sc = new SimpleClass();
            WriteLine(sc.ToString());
            WriteLine();

            // 继承和“is a”关系
            var packard = new Automobile("Packard", "Custom Eight", 1948);
            WriteLine(packard);
            WriteLine();

            // 设计基类及其派生类
            var book1 = new Book(
                "The Tempest",
                "0971655819",
                "Shakespeare, William",
                "Public Domain Press"
            );
            ShowPublicationInfo(book1);
            book1.Publish(new DateTime(2016, 8, 18));
            ShowPublicationInfo(book1);

            var book2 = new Book(
                "The Tempest",
                "Classic Works Press",
                "Shakespeare, William"
            );
            WriteLine(
                $"{book1.Title} and {book2.Title} are the same publication: "
                + $"{((Publication) book1).Equals(book2)}"
            );
            WriteLine();

            // 设计抽象基类及其派生类
            Shape[] shapes =
            {
                new Rectangle(10, 12),
                new Square(5),
                new Circle(3),
            };

            foreach (var shape in shapes)
            {
                WriteLine($"{shape}: area, {Shape.GetArea(shape)}; " +
                          $"perimeter, {Shape.GetPerimeter(shape)}");
                var rect = shape as Rectangle;
                if (rect != null)
                {
                    WriteLine($"    Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");
                    continue;
                }

                var sq = shape as Square;
                if (sq != null)
                {
                    WriteLine($"    Diagonal: {sq.Diagonal}");
                    continue;
                }
            }
        }

        public static void ShowPublicationInfo(Publication publication)
        {
            string pubDate = publication.GetPublicationDate();
            WriteLine(
                $"{publication.Title}, "
                + $"{(pubDate == "NYP" ? "Not Yet Published" : "published on " + pubDate):d} by {publication.Publisher}"
            );
        }
    }
}