using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 { 
    internal class Die { 
        //These lines create the current value of the die. The die value is private but can be accessed using the Get/Set.
        private int _dieValue;    
        public int dieValue {  get { return _dieValue; } set { _dieValue = value; } }        
        static Random rnd = new Random((int)DateTime.Now.Ticks); //This line creates the random that is used for the die rolling.
        /// <summary>
        /// This method can be accessed by other classes.
        /// It calls the rolling function and then returns the given value to the program.
        /// </summary>
        /// <returns>The rolled value</returns>
        /// 
        public int RollDice() {
            _dieValue = Rolling(rnd);
            Console.WriteLine("Value of this die is: " +  dieValue);            
            return _dieValue;
        }
        /// <summary>
        /// This method is called by the rollDice method. This method rolls the dice giving it a random integer value between 1 and 6.
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns>the rolled die value to the rollDice function</returns>
        private int Rolling(Random rnd) { 
            _dieValue = rnd.Next(1, 7); 
            return _dieValue;
        }
    }
}
