using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lamp Usage Flow Chart");
            //extra come back to this later

            Console.WriteLine("Does your lamp work?");

            string lampStat = Console.ReadLine();
            if (lampStat == "yes")
            {


            }
            //end of extra to be completed later
            Console.WriteLine("Is the lamp plugged in? enter 'yes' or 'no'");

            string plugged = Console.ReadLine();
            if (plugged.ToLower() == "yes");
            {
                Console.WriteLine("Is the bulb burned out?");

                string burned = Console.ReadLine();
                if (burned.ToLower() == "yes");
                {
                    Console.WriteLine("Replace bulb; and maybe try one of the new energy saving bulbs. They last for years");


                }
            }
            else
            {
                Console.WriteLine("Repair lamp... or even easier buy a new one! lol ;P");       
            }

            Console.WriteLine("What is height?");
            double height = Convert.ToDouble(Console.ReadLine());

            double pi = 3.14159;

            if (radius > 0)
            {
                if (height > 0)
                {
                    // Volume: radius^2 * height* pi
                    // we're doing radius * radius to mean radius^2
                    double volume = (radius * radius) * height * pi;
                    Console.WriteLine("The volume is " + volume);

                    // Surface area: 2pi r * height + 2pi r^2
                    double surfaceArea = (2 * pi * radius * height) + (2 * pi * radius * radius);
                    Console.WriteLine("The surface area is " + surfaceArea);

                }
                else
                {
                    Console.WriteLine("Height must not be negative!");
                }
            }
            else
            {
                Console.WriteLine("Radius cannot be negative!");
            }


            Console.ReadKey();

        }
    }
}
