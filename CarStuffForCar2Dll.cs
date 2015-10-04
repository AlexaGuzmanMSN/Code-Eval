using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDll2;
using System.Collections;

namespace CarStuffForCar2Dll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a new car and stepping on it!");
            Car2 myCar = new Car2("Zippy", 20);
            //myCar.CrankTunes(true);

           /* for (int i = 0; i < 10; i++)
                myCar.Accelerate(10); */

            //speed up past car's max speed to trigger the exception.
            try
            {
                for (int i = 0; i < 10; i++)
                myCar.Accelerate(10);
            }
         //TargetSite acttuaally returns a MethodBase object.
            catch(Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Member name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);

                //Console.WriteLine("Method: {0}", e.TargetSite);
                
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);

                Console.WriteLine("Stack: {0}", e.StackTrace);

                Console.WriteLine("Help Link: {0}", e.HelpLink);

        /* This next section is added to test the value returned from the Data property is not null.    
         */
                Console.WriteLine("\n-> Custom Data:");
                if (e.Data != null)
                {
                    foreach (DictionaryEntry de in e.Data)
                        Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                }
            }
            //The error has been handled, processing continues with the next staatement.
            Console.WriteLine("\n***** Out of exception logic *****");

            Console.ReadLine();
        }
    }
}
