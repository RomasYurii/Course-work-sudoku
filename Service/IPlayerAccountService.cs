using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_work.Service
{
    public interface IPlayerService
    {
        void DisplayPlayerStats(string userName);
        void UpdatePlayerPassword(string oldUserPassword, string newUserPassword);
        void CreatePlayer(string userName, string userPassword, string accountType);
        void DeletePlayer(string userName);
        void ShowAllPlayers();

    }
}
