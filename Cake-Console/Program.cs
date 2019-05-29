using System.Linq;
using System;

namespace Cake_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var name = args.Any() ? args[0] : "World";
            Console.WriteLine(Greetings(name));
        }

        public static string Greetings(string name)
        {
            return $"Hello {name}";
        }
    }
}
