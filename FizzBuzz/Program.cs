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
            Console.WriteLine("Enter the bumber you want to print fizz buzz for:");
            var value = Console.ReadLine();
            if (long.TryParse(value, out long number))
            {
                Generator gen = new Generator();
                var result = gen.GetFuzBuzzOutput(number);
                foreach (var output in result)
                {
                    Console.Write($"{output} ");
                }
                Console.WriteLine();
            } else
            {
                Console.WriteLine("You did not type a valid number");
            }
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
