using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtShop
{
    class Program
    {
        static void Main(string[] args)
        {
            TShirt Popple = new TShirt();
            Popple.LetsOrder();
        }
    }
    public class TShirt
    {  // Fields  
        private string size;
        private string color;


        public string Size
        {   // Getter of the property "size"   
            get { return this.size; }
            // Setter of the property "size"   
            set { this.size = value; }
        }
        
        public string Color
        {
            get { return this.color; }

            set
            {
                this.color = value;
            }
        }
        
        // Default constructor  
        public TShirt()
        {
            this.size = "Medium";
            this.color = "Red";

        }
        // Constructor with parameters  
        public TShirt(string size, string color)
        {
            this.size = size;
            this.color = color;

        }
                
        // Method LetsOrder  
        public void LetsOrder()
        {
            Console.WriteLine("TShirt " + size + " " + color);
            Console.ReadLine();
        }
    }
}
