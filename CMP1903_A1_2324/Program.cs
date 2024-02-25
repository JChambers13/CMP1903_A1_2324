using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            Testing testObject = new Testing();
            string userChoice;
            bool rollAgain = true;
            while (rollAgain)
            {
                testObject.tests();
                int sum = game1.diceRolling();
                Console.WriteLine("The sum of the dice rolls is: " + sum);
                
                Console.WriteLine("Would you like to stop rolling dice? Enter \"n\" to stop. Hit any other key to continue: ");
                userChoice = Console.ReadLine();
                if (userChoice == "n")
                {
                    rollAgain = false;
                }
                else
                {
                    Console.WriteLine("Dice will be rolled again.");
                    //Console.ReadLine();
                }


            }

            Console.WriteLine("No more dice rolling. Enter anything to close the program!");
            Console.ReadKey();
            
            
        }
    }
}
