using System;
using Cake_Console;
using Xunit;

namespace Cake_Tests
{
    public class HelloWorldTests
    {
        [Theory]
        [InlineData("Sujith")]
        [InlineData("Sujith Acharya")]
        public void Greetings_PassingName_ShouldReturnProperGreeting(string name)
        {
            var result = Program.Greetings(name);
            Assert.Equal($"Hello {name}", result);
        }
    }
}
