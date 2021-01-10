using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public abstract class TwoPlayersGame : Game
    {
        protected Player playerOne;
        protected Player playerTwo;

        public TwoPlayersGame(Player playerOne, Player playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }
    }
}
