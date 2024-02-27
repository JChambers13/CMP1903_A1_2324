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
            
        }

        static Random rnd = new Random((int)DateTime.Now.Ticks);
        /// <summary>
        /// This method can be accessed by other classes.
        /// It calls the rolling function and then returns the given value to the program.
        /// </summary>
        /// <returns>The rolled value</returns>
        /// 
        public int rollDice()
        {
            
            _dieValue = rolling(rnd);
            Console.WriteLine("Vallue of this die is: " +  dieValue);
            
            return _dieValue;
        }
        /// <summary>
        /// This method is called by the rollDice method. This method rolls the dice giving it a random integer value between 1 and 6. b
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns>the rolled die value to the rollDice function</returns>
        private int rolling(Random rnd)
        {
            _dieValue = rnd.Next(1, 7);
            return _dieValue;
        }

    }
}
