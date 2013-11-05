using System;

namespace Esendex.SimpleTddExample
{
    public static class Greeter
    {
        public static string GenerateGreeting(string name)
        {
            if (name == "Neil" || name == "Peter")
                return string.Format("Hey {0}!", name);

            return string.Format("Hello {0}", name);
        }
    }
}