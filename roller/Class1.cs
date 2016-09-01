using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_NDV
{
    public class RandomNumber
    {

        public static int RandomGen()
        {
            Random Rnum = new Random();

            Console.WriteLine("please enter a number of sides");

            int input = int.Parse(Console.ReadLine());

            int Number = Rnum.Next(1, input + 1);
            int Number2 = Rnum.Next(1, input + 1);
            
            Console.WriteLine("dice 1: " + Number);
            Console.WriteLine("dice 2: " + Number2);
            if (Number == 6 && Number2 == 6)
            {
                Console.WriteLine("You got box cars!");
            }
            else if(Number == 1 && Number2 == 1)
            {
                Console.WriteLine("You got snake eyes!");
            }



            return Number;




        }
    }
}
