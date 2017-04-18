using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class ReporterTest
    {
        [TestMethod]
        public void ReportFor0Occurency()
        {
            var entry = new[] {
                "1", "2", "lucky"};
            var expected = new Dictionary<string, string>()
            {
                {"fizz", "fizz: 0" },
                {"buzz", "buzz: 0" },
                {"fizzbuzz", "fizzbuzz: 0" },
                {"lucky", "lucky: 1" },
                {"an integer", "an integer: 2" }
            };
            var reporter = new Reporter();
            var output = reporter.GetReport(entry);
            output.ShouldBe(expected);
        }
        [TestMethod]
        public void Basic20Report()
        {
            var entry = new[] {
                "1", "2", "lucky", "4", "buzz",
                "fizz", "7", "8", "fizz", "buzz",
                "11", "fizz", "lucky", "14", "fizzbuzz",
                "16", "17", "fizz", "19", "buzz"};
            var expected = new Dictionary<string, string>()
            {
                {"fizz", "fizz: 4" },
                {"buzz", "buzz: 3" },
                {"fizzbuzz", "fizzbuzz: 1" },
                {"lucky", "lucky: 2" },
                {"an integer", "an integer: 10" }
            };
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
            var expected = new Dictionary<string, string>()
            {
                {"fizz", "fizz: 7" },
                {"buzz", "buzz: 5" },
                {"fizzbuzz", "fizzbuzz: 1" },
                {"lucky", "lucky: 13" },
                {"an integer", "an integer: 14" }
            };
            var reporter = new Reporter();
            var output = reporter.GetReport(entry);
            output.ShouldBe(expected);
        }
    }
}
