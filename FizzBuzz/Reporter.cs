using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Reporter
    {
        public Dictionary<string, string> GetReport(IEnumerable<string> values)
        {
            var report = new Dictionary<string, string>()
            {
                {"fizz", "fizz: 0" },
                {"buzz", "buzz: 0" },
                {"fizzbuzz", "fizzbuzz: 0" },
                {"lucky", "lucky: 0" },
                {"an integer", "an integer: 0" }
            };
             var content = values
                .GroupBy(v => long.TryParse(v, out long result) ? "an integer" : v)
                .Select(g => new {Key= g.Key, Value= $"{g.Key}: {g.LongCount()}"});
            foreach (var value in content)
            {
                report[value.Key] = value.Value;
            }
            return report;
        }
    }
}
