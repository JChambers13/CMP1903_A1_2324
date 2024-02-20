﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        public Die _die1 = new Die();
        public Die _die2 = new Die();
        public Die _die3 = new Die();
        

        public int diceRolling()
        {
            _die1.rollDice();
            _die2.rollDice();
            _die3.rollDice();
            return (_die1.dieValue + _die2.dieValue + _die3.dieValue);
            
        }
        

    }
}
