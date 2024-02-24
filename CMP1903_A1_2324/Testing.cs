using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        


        Game testGame = new Game();
        int tRoll;
        int tGame;
        Die testDie = new Die();
        public void tests()
        {
            tRoll = testDie.rollDice();
            Debug.Assert((0 < tRoll) && (tRoll < 7), "Dice roll too big");
            tGame = testGame.diceRolling();
            Debug.Assert((2 < tGame) && (tGame < 19), "Sum out of bounds");

        }
    }
}
