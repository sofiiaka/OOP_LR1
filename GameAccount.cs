using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr1
{
    public class GameAccount
    {
        private string UserName; 
        private int CurrentRating; 
        private static int GamesNumber; 
        private List<Game> historyGame = new List<Game>(); 

        public GameAccount(string userName, int currentRating)
        {
            if (CurrentRating < 0)
            {
                //Console.WriteLine("Rating can`t be less than one");
                throw new ArgumentOutOfRangeException(nameof(currentRating), "Rating cannot be less than one");
            }

            UserName = userName;
            CurrentRating = currentRating;
        }

        public void WinGame(GameAccount account, int rating)
        {
            if (rating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "The rating for which they are playing cannot be negative");
            }

            this.CurrentRating += rating;
            account.CurrentRating -= rating;

            if (account.CurrentRating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(this.CurrentRating), "Rating can`t be less than zero");
            }

            historyGame.Add(new Game((++GamesNumber), account, "Winner", rating, CurrentRating));
        }

        public void LoseGame(GameAccount account, int rating)
        {
            if (rating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "The rating for which they are playing cannot be less than zero");
            }

            this.CurrentRating -= rating;
            account.CurrentRating += rating;

            if (this.CurrentRating < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(this.CurrentRating), "Rating can`t be less than two");
            }

            historyGame.Add(new Game((++GamesNumber), account, "Defeat", rating, CurrentRating));
        }

        public void GetStatistics()
        {
            for (int i = 0; i < historyGame.Count; i++)
            {
                Console.WriteLine("ID:" + historyGame[i].GamesNumber);
                Console.WriteLine("PlayerOpponent: " + historyGame[i].AnotherPlayer.UserName);
                Console.WriteLine(historyGame[i].GameResult);
                Console.WriteLine("GameRating: " + historyGame[i].GameRating);
                Console.WriteLine(UserName + "'s rating now is = " + historyGame[i].CurrentRating);
                Console.WriteLine(historyGame[i].AnotherPlayer.UserName + "'s current rating = " + historyGame[i].AnotherPlayer.CurrentRating + "\n");

            }
        }
    }
}
