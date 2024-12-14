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
        private static int GlobalGameIndex = 1;
        public int GameIndex { get; private set; }
        public string PlayerName { get; set; }
        public bool IsWin { get; set; }

        private List<Game> gamesHistory;
        public Game(string playerName, bool isWin)
        {

            PlayerName = playerName;
            GameIndex = GlobalGameIndex++;
            IsWin = isWin;
        }
    }
}
