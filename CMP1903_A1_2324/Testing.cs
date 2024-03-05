using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903_A1_2324 { 
    internal class Testing { 
        //Creating a game and a die object, as well as two variables to store the results.
        Game testGame = new Game();
        int tRoll;
        int tGame;
        Die testDie = new Die();

        /// <summary>
        /// This method tests that the outputs are in the expected range. The rollDice function is tested first, then the rollAndSum.
        /// </summary>
        public void Tests() { 
            
            tRoll = testDie.RollDice(); //This line rolls one die
            Debug.Assert((0 < tRoll) && (tRoll < 7), "Dice roll too big"); //This line uses Debug.Assert to check that the die is within expected range
            tGame = testGame.RollAndSum(); //This line calls rollAndSum method, which rolls 3 die.
            Debug.Assert((2 < tGame) && (tGame < 19), "Sum out of bounds"); //This line uses Debug.Assert to check the result is within expected range.
        }
    }
}
