using System;

namespace Lab2GitTestConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new TestClass
            {
                TestProperty = "TestValue"
            };
            Console.WriteLine(s.TestProperty);
        }
    }
}
