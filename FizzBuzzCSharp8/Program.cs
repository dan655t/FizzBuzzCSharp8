using System;
using System.Linq;

namespace FizzBuzzCSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable
                .Range(1, 100)
                .ToList()
                .ForEach(n => Console.WriteLine(FizzBuzz(n)));
        }

        private static string FizzBuzz(int n)
            => (n % 3, n % 5, n) switch
        {
            (0, 0, _) => "FizzBuzz",
            (0, _, _) => "Fizz",
            (_, 0, _) => "Buzz",
            (_, _, _) => n.ToString()
        };
    }
}
