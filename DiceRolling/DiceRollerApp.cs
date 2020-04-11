using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRolling
{
    class DiceRollerApp
    {

        public static int RandomNumber(int numberOfSides)
        {
            Random Rnd = new Random(Guid.NewGuid().GetHashCode());
            return Rnd.Next(1, numberOfSides);
        }

    }
}
