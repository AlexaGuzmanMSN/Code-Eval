using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEReverseWordsSep5
{
    class Program
    {
        static void Main(string[] args)
        {


            string store = " ";
            string line = "OH , Medina in live I";
            string[] arrayLine = line.Split();
            Array.Reverse(arrayLine);

            foreach (string result in arrayLine)
            {
                store = store + " " + result;
            }
            Console.WriteLine(store);
            Console.ReadLine();
            

        }
    }
}
