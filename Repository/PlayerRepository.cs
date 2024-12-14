using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_work
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DbContext _context;
        public PlayerRepository(DbContext context)
        {
            _context = context;
        }
        public void AddPlayer(GameAccount player)
        {
            _context.Players.Add(player);

        }
        public GameAccount GetPlayerByName(string userName)
        {
            return _context.Players.FirstOrDefault(p => p.UserName == userName);
        }
        public void UpdatePlayerPassword(string oldUserPassword, string newUserPassword)
        {
            var player = _context.Players.FirstOrDefault(p => p.UserPassword == oldUserPassword);
            if (player != null)
            {
                player.UserPassword = newUserPassword;
            }
        }
        public void IncreaseRating(string userName)
        {
            var player = _context.Players.FirstOrDefault(p => p.UserName == userName);
            if (player != null)
            {
                if (player.AccountType == "doubleRating")
                {
                    player.CurrentRating += 20;
                }
                else
                {
                    player.CurrentRating += 10;
                }
            }
        }
        public string GetRating(string userName)
        {
            var player = _context.Players.FirstOrDefault(p => p.UserName == userName);
            if (player != null)
            {
                return player.CurrentRating.ToString();
            }
            return null;
        }
 
        public void DeletePlayer(string userName)
        {


            foreach (var game in _context.Players)
            {
                if (game.UserName == userName)
                {
                    _context.Players.Remove(game);
                    break;
                }
            }

        }

        public List<GameAccount> GetAllPlayers()
        {
            return _context.Players;
        }
    }
}
