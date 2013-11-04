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
        public void GenerateGreeting_WhenNameSam_ThenSamIsAwesome()
        {
            Assert.That(Greeter.GenerateGreeting("Sam"), Is.EqualTo("Sam, you are awesome!"));
        }
    }
}
