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

            Console.WriteLine("Is the lamp plugged in? Please enter 'yes' or 'no'");

            string plugged = Console.ReadLine();
            if (plugged.ToLower() == "yes") 
            {
                Console.WriteLine("Is the bulb burned out?");

                
            }else
            {
                    Console.WriteLine("Ummmm...You have... to..plug...it...in. Lamps need electricity");
                }

            string burned = Console.ReadLine();

            if (burned.ToLower() == "yes") 
            {
                Console.WriteLine("Replace bulb; and maybe try one of the new energy saving bulbs. They last for years! :D");

            
            
            }   else if (burned.ToLower() == "no")
            {
                    Console.WriteLine("Repair lamp... or even easier, buy a new one! lol ;P");
                }                
              
                else 
                {
                    Console.WriteLine("You must enter 'yes' or 'no', please follow directions!");
                        }
                                
     
            Console.ReadKey();

        }
    }
}
