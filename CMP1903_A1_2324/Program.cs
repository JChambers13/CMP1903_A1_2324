using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
    internal class Program { 
        static void Main(string[] args) { 
            //These lines create objects of the test and game classes.
            Game game1 = new Game();
            Testing testObject = new Testing();
            string userChoice; //userChoice is a variable used to decide whether the user will roll die again. 
            bool rollAgain = true; //At the start, this variable is true to start the while loop. This can be made false after the first rolling.
            Console.WriteLine("These die rolls are for testing");
            testObject.Tests(); //The tests method is called which tests that the output is as expected.
            Console.WriteLine("Testing complete");
            int continuousSum = 0; //The variable that holds the value of all rolls combined.
            //This while loop is used so the user can roll the dice as many times as they like.
            while (rollAgain)
            {
                int sum = game1.RollAndSum(); //Calls the rollAndSum function to roll the three die and sum the rolls.
                continuousSum += sum;
                Console.WriteLine("The sum of the dice rolls is: " + sum + ". And the continuous total is: " + continuousSum); //Outputs the sum and continuous sum.
                Console.WriteLine("Would you like to stop rolling dice? Enter \"n\" to stop. Hit any other key to continue: "); //Asks user if they want to stop rolling dice
                userChoice = Console.ReadLine();
                if (userChoice == "n") //If user types "n", the loop ends.
                {
                    rollAgain = false;
                }
                else //If user types anything else, dice is rolled again.
                {
                    Console.WriteLine("Dice will be rolled again.");
                }
            }      
        }
    }
}
