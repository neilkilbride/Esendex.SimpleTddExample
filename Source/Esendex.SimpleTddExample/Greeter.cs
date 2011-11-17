using System;

namespace Esendex.SimpleTddExample
{
    public static class Greeter
    {
        public static string GenereateGreeting(string name)
        {
            return string.Format("Nice to meet you {0}", name);
        }
    }
}