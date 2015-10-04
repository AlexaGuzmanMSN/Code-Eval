using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDll2
{
    /*public class Radio
    {
        public void TurnOn(bool on)
        {
            if (on)
                Console.WriteLine("Jamming...");
            else
                Console.WriteLine("Quiet time...");
        }
    }*/
    public class Car2
    {
        //Constant for maximum speed.
        public const int MaxSpeed = 100;

        //Car properties.
        public int CurrentSpeed 
        {
            get; set; 
        }
        public string PetName
        {
            get; set;
        }

    //Is the car still operational?
        private bool carIsDead;

    //A car has-a radio.
       // private Radio theMusicBox = new Radio();

    //Constructors.
        public Car2()
        {}
            public Car2(string name, int speed)
            {
                CurrentSpeed = speed;
                PetName = name;
            }
        //public void CrankTunes(bool state)
       // {
            //Delegate request to inner object.
          //  theMusicBox.TurnOn(state);
        //}

        //See if Car is overheated.
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                //if (CurrentSpeed > MaxSpeed)
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;

            //we need to call the HelpLink property, thus we need to create a local variable before
            //throwing the Exception object.

                    Exception ex = new Exception(string.Format("{0} has overheated!", PetName));
                    ex.HelpLink = "http://www.CarsRUs.com";
                    
            /*This section is to try out the Exception Data Property. Note: this step stops exactly right before
             * the "throw ex;*/
            //This is the stuff in custom data regarding the error.

                    ex.Data.Add("TimeStamp", string.Format("The car exploded at {0}", DateTime.Now));
                    ex.Data.Add("Cause", "You have a lead foot!");

                    
                    throw ex;

                    /* this section is commented out to try the helplink property //Use the "throw" 
                      keyword to raise an exception.
                    throw new Exception(string.Format("{0} has overheated!", PetName));*/
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
                /*{
                    Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    carIsDead = true;
                }*/
                
        }
    }
}


