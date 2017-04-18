using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class GeneratorTest
    {
        [TestMethod]
        public void GetFirst10Numbers()
        {
            //Expected result for 10
            var result = new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz" };
            var generator = new Generator();
            var output = generator.GetFuzBuzzOutput(10);
            output.ShouldBeSameAs(result);
        }
    }
}
