using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr1
{
    public class Game
    {
        public int GamesNumber; 
        public GameAccount AnotherPlayer;
        public string GameResult; 
        public int GameRating; 
        public int CurrentRating; 

        public Game(int gamesNumber, GameAccount anotherPlayer, string gameResult, int rating, int currRating)
        {
            GamesNumber = gamesNumber;
            AnotherPlayer = anotherPlayer;
            GameResult = gameResult;
            GameRating = rating;
            CurrentRating = currRating;
        }
    }
}
