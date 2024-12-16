using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course_work.Game;

namespace Course_work
{
    public class DbContext
    {
        public List<GameAccount> Players { get; set; } = new List<GameAccount>();
        public List<GameHistory> GamesHistory { get; set; } = new List<GameHistory>();

        public DbContext()
        {

        }
    }
}
