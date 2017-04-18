using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Generator
    {
        public IEnumerable<string> GetFuzBuzzOutput(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                    yield return i.ToString();
                if (i % 3 == 0)
                    yield return "fizz";
                if (i % 5 == 0)
                    yield return "buzz";
            }
        }
    }
}
