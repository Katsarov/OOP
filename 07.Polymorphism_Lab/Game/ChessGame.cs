using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class ChessGame : TwoPlayersGame
    {
        private bool isWhitePlaying;

        public ChessGame(Player playerOne, Player playerTwo)
            :base(playerOne, playerTwo)
        {

        }

        public override void Start()
        {
            base.Start();
        }

        public override void Stop()
        {
            base.Stop();
        }

        public Player GetMovingPlayer()
        {
            if (isWhitePlaying)
            {
                return playerOne;
            }
            else
            {
                return playerTwo;
            }
        }

        public override string GetDescription()
        {
            return $"{playerOne} is playing {playerTwo} and they are thinking hard!";
        }
    }
}
