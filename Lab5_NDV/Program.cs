using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab5_NDV
{
    class Program
    {
        static void Main(string[] args)
        {


            
            
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n)");
            string roll = Console.ReadLine().ToUpper();

            if (roll == "Y")
            {
               


               


                string Again;

                int RollNum = 1;

                do
                {
                    Console.WriteLine("roll " + RollNum);
                    RandomNumber.RandomGen();
                    Console.WriteLine("Would you like to roll again?");
                    Again = Console.ReadLine().ToUpper();
                    RollNum++;
                } while (Again == "Y");
            }
        }
    }
}
