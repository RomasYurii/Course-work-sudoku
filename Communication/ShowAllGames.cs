using Course_work.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course_work.Game;

namespace Course_work.Communication
{
    public class ShowAllGames : ICommand
    {
        private readonly IGameService _ShowAllGames;

        public ShowAllGames(IGameService gameService)
        {
            _ShowAllGames = gameService;
        }

        public void Execute()
        {
            try
            {
                Console.WriteLine("Enter player name: ");

                string playerName = Console.ReadLine();

                _ShowAllGames.ShowHistoryStats(playerName);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid type.");
            }
        }

        public string GetDescription() => "Show all games for player";
    }
}
