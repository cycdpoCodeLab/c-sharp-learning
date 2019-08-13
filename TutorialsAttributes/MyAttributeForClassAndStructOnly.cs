using System;

namespace TutorialsAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class MyAttributeForClassAndStructOnly : Attribute
    {
    }
}