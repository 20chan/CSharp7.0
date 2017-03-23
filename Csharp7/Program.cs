using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTuple();

            Console.ReadLine();
        }

        static void TestTuple()
        {
            /*
            var a = (10, 5);
            Console.WriteLine($"Type of (10, 5) : {a.GetType()}");
            Console.WriteLine($"Item1 of (10, 5) : {a.Item1}");
            Console.WriteLine($"Item2 of (10, 5) : {a.Item2}");

            int b = 1, c = 2;

            (b, c) = (c, b);
            Console.WriteLine($"b = {b}, c = {c}");
            */
            var named = (name: "아드", age: "17", job: "여고생");
            PrintPerson(named);
        }

        static void PrintPerson((string name, string age, string job) p)
        {
            Console.WriteLine($"{p.age}세 {p.job}인 {p.name}에요");
        }
    }
}
