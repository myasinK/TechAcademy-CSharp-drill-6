using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("=================================================================");
            Console.WriteLine("Please enter package weight: ");
            float weight = float.Parse( Console.ReadLine() );
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter package width: ");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter package height: ");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter package length: ");
                float length = float.Parse(Console.ReadLine());
                float quote = (width + length + height) * weight / 100.0f;

                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping is: $" + Convert.ToString( quote ) + "\nThank you.");
                }
            }
        }
    }
}
