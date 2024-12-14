using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_work
{
    public class DbContext
    {
        public List<GameAccount> Players { get; set; } = new List<GameAccount>();
        //public List<Game> Games { get; set; } = new List<Game>();

        public DbContext()
        {

        }
    }
}
