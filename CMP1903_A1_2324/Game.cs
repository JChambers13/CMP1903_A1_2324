using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 { 
    internal class Game { 
        //these are three object instantiaons of die objects. They are private as they do not need to be accessed outside of the game class
        private Die _die1 = new Die(); 
        private Die _die2 = new Die();
        private Die _die3 = new Die();
        /// <summary>
        /// This method rolls each dice, and then adds up the total value of the dice.
        /// </summary>
        /// <returns>The sum of the three dice rolls</returns>
        public int RollAndSum() {
            _die1.dieValue = _die1.RollDice();
            _die2.dieValue = _die2.RollDice();
            _die3.dieValue = _die3.RollDice();
            return (_die1.dieValue + _die2.dieValue + _die3.dieValue);
        }
    }
}
