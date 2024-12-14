using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_work
{
    public abstract class GameAccount
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public static int Id = 0;
        public string AccountType { get; set; }

        public int CurrentRating
        {
            get => _currentRating;
            set => _currentRating = value < 0 ? 1 : value;
        }
        private int _currentRating;

        //protected List<Game> GameHistory = new List<Game>();

        protected GameAccount(string userName, string userPassword,string accountType )
        {
            Id++;
            UserName = userName;
            UserPassword = userPassword;
            CurrentRating = 10;
            AccountType = accountType;
        }

        public virtual void WinGame()
        {
            //GameHistory.Add(game);
            CurrentRating += 10;
        }

        public void GetStats()
        {
            Console.WriteLine($"Player statistics for {UserName}:");
            Console.WriteLine($"Current rating: {CurrentRating}");
            Console.WriteLine("Game history:");
            //foreach (var game in GameHistory)
            //{
            //    string result = game.IsWin ? "Win" : "Loss";
            //    Console.WriteLine($" - Game ID: {game.GameId}, Opponent: {game.OpponentName}, Winner: {game.WinnerName}, Result: {result}, Rating change: {game.CalculateRatingChange()}");
            //}
            Console.WriteLine();
        }
    }

    public class StandardAccount : GameAccount
    {
        public StandardAccount(string userName, string userPassword, string accountType) : base(userName, userPassword, accountType) { }
    }

   // public class DoubleRating : GameAccount
    //{
     //   public DoubleRating(string userName, string userPassword) : base(userName, userPassword) { }

        //public override void WinGame(Game game)
        //{
        //    CurrentRating += game.CalculateRatingChange() * 2;
        //    GameHistory.Add(game);
        //}
    //}
}
