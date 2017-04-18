using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Generator
    {
        public IEnumerable<string> GetFuzBuzzOutput(long number)
        {
            if(number < 0)
            {
                yield return "Only positive numbers accepted";
            }
            for (long i = 1; i <= number; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    yield return i.ToString();
                } else
                {
                    string response = string.Empty;
                    if (i % 3 == 0)
                        response += "fizz";
                    if (i % 5 == 0)
                        response += "buzz";
                    yield return response;
                }
                
            }
        }
    }
}
