using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delopgave3_Week1
{
    class Program
    {

   
    static void Main(string[] args)
        {
            int Number1;
            int Number2;
            int sum; 

            Console.WriteLine("Enter first Number: ");

            var UserInput1 = Console.ReadKey();

            Console.WriteLine("\n");
            Console.WriteLine("Enter second Number: ");

            var UserInput2 = Console.ReadKey();
        
            Console.WriteLine("\n");

           
                Number1 = int.Parse(UserInput1.KeyChar.ToString());
                Console.WriteLine("Number 1 is: " + Number1); 
          

           
                Number2 = int.Parse(UserInput2.KeyChar.ToString());
                Console.WriteLine("Number 2 is: " + Number2);


            sum = Number1 + Number2;
            Console.WriteLine("Summen er:" + sum); 

        }
    }
}
