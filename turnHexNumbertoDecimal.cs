using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnHexNumbertoDecimalInClassJuly26
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexString = "9f";
            int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(num);
            Console.ReadLine();

        }
    }
}
