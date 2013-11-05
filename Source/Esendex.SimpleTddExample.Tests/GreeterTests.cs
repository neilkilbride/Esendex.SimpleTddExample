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

        [Test]
        public void WhenNameIsNeil_ThenGreeterSaysHey()
        {
            Assert.That(Greeter.GenerateGreeting("Neil"), Is.EqualTo("Hey Neil"));
        }

        [Test]
        public void WhenNameIsPeter_ThenGreeterSaysHey()
        {
            Assert.That(Greeter.GenerateGreeting("Peter"), Is.EqualTo("Hey Peter"));
        }
    }
}
