using System;

namespace Esendex.SimpleTddExample
{
    public static class Greeter
    {
        public static string GenerateGreeting(string name)
        {
            if (name == "Neil")
                return "Neil, you are awesome!";
            if (name == "Sam")
                return "Go away Sam";
            return string.Format("Nice to meet you {0}", name);
        }
    }
}