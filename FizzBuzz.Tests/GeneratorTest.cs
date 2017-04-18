using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class GeneratorTest
    {
        [TestMethod]
        public void ZeroGenerated()
        {
            var expected = Array.Empty<string>();
            var generator = new Generator();
            var output = generator.GetFuzBuzzOutput(0);
            output.ShouldBe(expected);
        }
        [TestMethod]
        public void NegativeNumbersGenerated()
        {

            var expected = new[] { "Only positive numbers accepted" };
            var generator = new Generator();
            var output = generator.GetFuzBuzzOutput(-1);
            output.ShouldBe(expected);
        }
        [TestMethod]
        public void GetFirst10Numbers()
        {
            var expected = new[] {
                "1", "2", "lucky", "4", "buzz",
                "fizz", "7", "8", "fizz", "buzz"
            };
            var generator = new Generator();
            var output = generator.GetFuzBuzzOutput(10);
            output.ShouldBe(expected, Case.Insensitive);
        }
        [TestMethod]
        public void GetFirst20Numbers()
        {
            var expected = new[] {
                "1", "2", "lucky", "4", "buzz",
                "fizz", "7", "8", "fizz", "buzz",
                "11", "fizz", "lucky", "14", "fizzbuzz",
                "16", "17", "fizz", "19", "buzz"};
            var generator = new Generator();
            var output = generator.GetFuzBuzzOutput(20);
            output.ShouldBe(expected, Case.Insensitive);
        }
        [TestMethod]
        public void GetFirst40Numbers()
        {
            var expected = new[] {
                "1", "2", "lucky", "4", "buzz",
                "fizz", "7", "8", "fizz", "buzz",
                "11", "fizz", "lucky", "14", "fizzbuzz",
                "16", "17", "fizz", "19", "buzz",
                "fizz", "22", "lucky", "fizz", "buzz",
                "26", "fizz", "28", "29", "lucky",
                "lucky", "lucky", "lucky", "lucky", "lucky",
                "lucky", "lucky", "lucky", "lucky", "buzz"};
            var generator = new Generator();
            var output = generator.GetFuzBuzzOutput(40);
            output.ShouldBe(expected, Case.Insensitive);
        }
    }
}
