using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Esendex.SimpleTddExample.Tests
{
    [TestFixture]
    public class GreeterTests
    {
        [Test]
        public void WhenNameIsJoe_ThenGreeterSaysHi()
        {
            Assert.That(Greeter.GenerateGreeting("Joe"), Is.EqualTo("Hello Joe"));
        }
    }
}
