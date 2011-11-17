using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esendex.SimpleTddExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! ...What's your name? ");
            string input = Console.ReadLine();

            Console.WriteLine( Greeter.GenerateGreeting(input));

            Console.ReadLine();
        }
    }
}
