using System.Collections.Generic;

namespace Course_work.Game
{
    public interface IGameRepository
    {
        void AddGameHistory(string playerName, bool isWin);
        List<Game> GetAll();
        List<Game> GetGamesByPlayer(string playerName);
    }
}
