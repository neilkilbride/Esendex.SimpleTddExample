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
        public void GenerateGreeting_WhenNameSam_ThenSamIsAwesome()
        {
            Assert.That(Greeter.GenerateGreeting("Sam"), Is.EqualTo("Sam, you are awesome!"));
        }

    }
}
