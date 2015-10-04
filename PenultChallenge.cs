using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenultChallengeonCodeEvalJuly26
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;
            string name = "some line with text";
            var a = name.Split(' ');
            Console.WriteLine(a[a.Length - 2]);
            System.Console.ReadLine();
        }
    }
}
