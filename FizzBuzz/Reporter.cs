using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Reporter
    {
        public IEnumerable<string> GetReport(IEnumerable<string> values)
        {
            return values
                .GroupBy(v => long.TryParse(v, out long result) ? "an integer" : v)
                .Select(g => $"{g.LongCount()} {g.Key}");
        }
    }
}
