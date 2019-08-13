// Tutorial: https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/attributes

using System;
using System.Reflection;

namespace TutorialsAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 如何使用附加到代码元素的特性
            TypeInfo typeInfo = typeof(ObsoleteClass).GetTypeInfo();
            Console.WriteLine($"The assembly qualified name of ObsoleteClass is {typeInfo.AssemblyQualifiedName}");

            var attrs = typeInfo.GetConstructors();
            foreach (var attr in attrs)
            {
                Console.WriteLine($"Attribute on ObsoleteClass: {attr.GetType().Name}");
            }

            Console.WriteLine();

            // 基类库 (BCL) 中的常见特性
        }
    }
}