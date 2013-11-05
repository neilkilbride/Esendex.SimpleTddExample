using System;

namespace Esendex.SimpleTddExample
{
    public static class Greeter
    {
        public static string GenerateGreeting(string name)
        {
            // Useless comment
            return string.Format("Hello {0}", name);
        }
    }
}