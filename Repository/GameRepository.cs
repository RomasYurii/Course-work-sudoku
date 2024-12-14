using System.Collections.Generic;
using System.Linq;

namespace Course_work.Game
{
    public class GameRepository : IGameRepository
    {
        private List<Game> _gamesHistory = new List<Game>();

        public void AddGameHistory(string playerName, bool isWin)
        {
            Game game = new Game(playerName, isWin);
            _gamesHistory.Add(game);
        }
        public List<Game> GetAll()
        {
            return _gamesHistory;
        }

        public List<Game> GetGamesByPlayer(string playerName)
        {
            return _gamesHistory.Where(game => game.PlayerName == playerName).ToList();
        }
    }
}
