using System;
using System.Collections.Generic;
using Course_work.Game;

namespace Course_work.Game
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private static int _gameIndex = 1;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public void AddGame(string playerName, bool isWin)
        {
            //var game = new Game( playerName, isWin);
            _gameRepository.AddGameHistory(playerName, isWin);
        }

        public void ShowHistoryStats(string playerName)
        {
            var games = _gameRepository.GetGamesByPlayer(playerName);

            Console.WriteLine($"\nGames history for {playerName}:");
            foreach (var game in games)
            {
                Console.WriteLine($"Game ID: {game.GameIndex} | Player: {game.PlayerName} | Win: {game.IsWin}");
            }
        }
    }
}
