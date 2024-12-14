using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_work
{
    public interface IPlayerRepository
    {
        void AddPlayer(GameAccount player);
        GameAccount GetPlayerByName(string userName);
       // GameAccount GetPlayerPassword(string userName);
        List<GameAccount> GetAllPlayers();

        void UpdatePlayerPassword(string oldUserPassword, string newUserPassword);

        void DeletePlayer(string userName);


    }
}
