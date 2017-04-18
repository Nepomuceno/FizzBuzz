using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the bumber you want to print fizz buzz for:");
            var value = Console.ReadLine();
            if (long.TryParse(value, out long number))
            {
                Generator gen = new Generator();
                // Avoid multiple enumertions
                var result = gen.GetFuzBuzzOutput(number).ToArray();
                foreach (var output in result)
                {
                    Console.Write($"{output} ");
                }
                Console.WriteLine();
                Reporter rep = new Reporter();
                var report = rep.GetReport(result);
                foreach (var output in report)
                {
                    Console.WriteLine($"{output} ");
                }
            } else
            {
                Console.WriteLine("You did not type a valid number");
            }
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
