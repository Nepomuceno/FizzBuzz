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
            output.ShouldBe(result, Case.Insensitive);
        }
        [TestMethod]
        public void GetFirst20Numbers()
        {
            //Expected result for 20
            var result = new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz", "16", "17", "fizz", "19", "buzz" };
            var generator = new Generator();
            var output = generator.GetFuzBuzzOutput(20);
            output.ShouldBe(result, Case.Insensitive);
        }
    }
}
