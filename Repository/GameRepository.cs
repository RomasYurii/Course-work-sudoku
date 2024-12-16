using System.Collections.Generic;
using System.Linq;

namespace Course_work.Game
{
    public class GameRepository : IGameRepository
    {
        //private List<GameHistory> _gamesHistory = new List<GameHistory>();
        private readonly DbContext _dbContext;

        public GameRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddGameHistory(string playerName, bool isWin)
        {
            GameHistory game = new GameHistory(playerName, isWin);
            _dbContext.GamesHistory.Add(game);
        }
        public List<GameHistory> GetAll()
        {
            return _dbContext.GamesHistory;
        }

        public List<GameHistory> GetGamesByPlayer(string playerName)
        {
            return _dbContext.GamesHistory.Where(game => game.PlayerName == playerName).ToList();
        }
    }
}
