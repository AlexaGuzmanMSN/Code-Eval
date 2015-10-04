using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionStuffAug30
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(new Program().Foo());
            /* First we call the Foo() Method. Whatever is in the () gets first 
            dibs, in this case: (new Program().Foo()). this is like when we do math and we do what's 
             * inside the () first. */

            System.Console.ReadKey(); 
        }
       String Foo() 
        {
            try
            {
                throw new System.Exception("An Exception");  /* We throw an error and 
                this stops the try statement */

                System.Console.Write("Inside Try"); /* The computer does not even try this because we threw
                                                     *an error/exception in the previous line. */
            }
            catch (System.Exception ex) //Here we catch the error/exception and name it "ex".
            {
                // NOTE: there is no Console.WriteLine here.
                return " HERE - " + ex.Message + " yep."; /* This replaces the above call, in this case:
                                                            (new Program().Foo()) with the return value.*/

            }
            //finally
            //When Should We Use try-finally? When we need to free up 
                //the resources as early as possible when the resource is no longer needed.
            //Perhaps you faced such a situation when you could not delete some directory 
                //or a file because it is being used by a running process.
            
            finally /* This code will always execute. This section will write FIRST, because the CATCH 
                     * section does not have a Console.WriteLine.  */
            {
                System.Console.Write("Finally");
            }
        return "Outside Try";

        }
    }
}

