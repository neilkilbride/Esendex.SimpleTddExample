using System;

namespace Esendex.SimpleTddExample
{
    public static class Greeter
    {
        public static string GenerateGreeting(string name)
        {
            if (name == "Sam")
                return name + ", you are awesome!";

            return string.Format("Nice to meet you {0}", name);
        }
    }
}