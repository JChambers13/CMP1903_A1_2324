﻿using System;
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

        public int rollDice()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            dieValue = rnd.Next(1, 7);
            Console.WriteLine(_dieValue);
            return dieValue;
        }

    }
}
