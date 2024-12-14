using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Course_work.Game
{

    public class Game
    {
        public static int GameIndex = 1;
        public string PlayerName { get; set; }
        public bool IsWin { get; set; }

        private List<Game> gamesHistory;
        public Game(string playerName, bool isWin)
    {

        PlayerName = playerName;
        GameIndex++;
        IsWin = isWin;
    }

        public void AddGameHistory(string playerName, bool isWin)
        {
            Game game = new Game(playerName, isWin);
            gamesHistory.Add(game);
        }
        public void GeteHistoryStats()
        {
            Console.WriteLine($"\nІсторія ігор для {PlayerName}:");
            foreach (var game in gamesHistory)
            {
                Console.WriteLine($"{Game.GameIndex} | {game.PlayerName} | {game.IsWin}");
            }
        }
    }
}
