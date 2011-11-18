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
        public void GenerateGreeting_WhenNameAnn_ThenNiceToMeetYouAnn()
        {
            Assert.That(Greeter.GenerateGreeting("Ann"), Is.EqualTo("Nice to meet you Ann"));
        }

        [Test]
        public void GenerateGreeting_WhenNameSam_ThenGoAwaySam()
        {
            Assert.That(Greeter.GenerateGreeting("Sam"), Is.EqualTo("Go away Sam"));
        }

        [Test]
        public void GenerateGreeting_WhenNameNeil_ThenYouAreAwesome()
        {
            Assert.That(Greeter.GenerateGreeting("Neil"), Is.EqualTo("Neil, you are awesome!"));
        }
    }
}
