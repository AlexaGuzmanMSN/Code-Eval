using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input string
            string line = "This is a MIXED case string.";

            // Call ToLower instance method, which returns a new copy.
            string lower = line.ToLower();

            // Display results
            Console.WriteLine("{0}, {1}",line, lower);
            System.Console.ReadLine();
        }
    }
}
