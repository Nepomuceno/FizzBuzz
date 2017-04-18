using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class ReporterTest
    {
        [TestMethod]
        public void Basic20Report()
        {
            var entry = new[] {
                "1", "2", "lucky", "4", "buzz",
                "fizz", "7", "8", "fizz", "buzz",
                "11", "fizz", "lucky", "14", "fizzbuzz",
                "16", "17", "fizz", "19", "buzz"};
            var expected = new[]{ "10 an integer", "2 lucky", "3 buzz", "4 fizz", "1 fizzbuzz" };
            var reporter = new Reporter();
            var output = reporter.GetReport(entry);
            output.ShouldBe(expected);
        }
        
        [TestMethod]
        public void Basic40Report()
        {
            var entry = new[] {
                "1", "2", "lucky", "4", "buzz",
                "fizz", "7", "8", "fizz", "buzz",
                "11", "fizz", "lucky", "14", "fizzbuzz",
                "16", "17", "fizz", "19", "buzz",
                "fizz", "22", "lucky", "fizz", "buzz",
                "26", "fizz", "28", "29", "lucky",
                "lucky", "lucky", "lucky", "lucky", "lucky",
                "lucky", "lucky", "lucky", "lucky", "buzz"};
            var expected = new[] { "14 an integer", "13 lucky", "5 buzz", "7 fizz", "1 fizzbuzz" };
            var reporter = new Reporter();
            var output = reporter.GetReport(entry);
            output.ShouldBe(expected);
        }
    }
}
