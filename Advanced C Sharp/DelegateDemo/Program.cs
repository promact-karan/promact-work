using System;
namespace DelegateDemo
{
    class Program
    {
        delegate void TestReference();
        static void Main(string[] args)
        {
            AnotherMethod(TestMethod);
        }

        static void TestMethod()
        {
            Console.WriteLine("Hello From Test Method");
        }

        static void AnotherMethod(TestReference testReference)
        {
            testReference();
            Console.WriteLine("Hello From Another Method");
        }

    }
}