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
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            
            Game game1 = new Game();
            Testing testObject = new Testing();
            
            int sum = game1.diceRolling();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
