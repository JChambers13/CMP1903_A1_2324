using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        private int _dieValue;
        
        public int dieValue
        {
            get { return _dieValue; }
            set { _dieValue = value; }
            //Method
        }

        

        /// <summary>
        /// This function rolls the die. It gives the dice a random value between 1 and 6 inclusive.
        /// </summary>
        /// <returns>The rolled value</returns>
        /// 

        public int rollDice()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            _dieValue = test1(rnd);
            Console.WriteLine("Vallue of this die is: " +  dieValue);
            
            return _dieValue;
        }

        private int test1(Random rnd)
        {
            _dieValue = rnd.Next(1, 7);
            return _dieValue;
        }

    }
}
