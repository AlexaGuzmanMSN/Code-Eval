using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageDistributionChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int i;
            age = Convert.ToInt32(Console.ReadLine());
                                    
                if (age >= 0 && age <= 2)
                {
                    System.Console.WriteLine("Still in Mama's arms");
                }
                else if (age >= 3 && age <= 4)
                {
                    System.Console.WriteLine("Preschool Maniac");
                }
                else if (age >= 5 && age <= 11)
                {
                    System.Console.WriteLine("Elementary school");
                }
                else if (age >= 12 && age <= 14)
                {
                    System.Console.WriteLine("Middle school");
                }
                else if (age >= 15 && age <= 18)
                {
                    System.Console.WriteLine("High school");
                }
                else if (age >= 19 && age <= 22)
                {
                    System.Console.WriteLine("College");
                }
                else if (age >= 23 && age <= 65)
                {
                    System.Console.WriteLine("Working for the man");
                }
                else if (age >= 66 && age <= 100)
                {
                    System.Console.WriteLine("The Golden Years");
                }
                else if (age < 0 && age > 100)
                {
                    System.Console.WriteLine("This program is for humans");
                }
                System.Console.ReadLine();
            
        }

    }

}   
    

