using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Course_work.Service
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public string IsLoggedIn;

        public void DisplayPlayerStats(string userName)
        {
            var player = _playerRepository.GetPlayerByName(userName);
           // if (player != null) player.GetStats();
           // else Console.WriteLine($"Player {userName} not found.");
        }

        public void UpdatePlayerPassword(string oldUserPassword, string newUserPassword)
        {
            _playerRepository.UpdatePlayerPassword(oldUserPassword, newUserPassword);
        }

        public void CreatePlayer(string userName, string userPassword, string accountType)
        {
            if (_playerRepository.GetPlayerByName(userName) != null)
            {
                Console.WriteLine($"Player with the name '{userName}' already exists.");
                return;
            }
            GameAccount newPlayer;
            newPlayer = new StandardAccount(userName, userPassword, accountType);
            //switch (accountType)
            //{
            //    case "standard":
            //        newPlayer = new StandardAccount(userName, userPassword);
            //        break;
            //    case "doubleRating":
            //        newPlayer = new DoubleRating(userName, userPassword);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid account type.");
            //        return;
            //}
            _playerRepository.AddPlayer(newPlayer);
        }

        public void LoginPlayer(string userName, string userPassword)
        {
            var player = _playerRepository.GetPlayerByName(userName);

            if (player != null)
            {
                if (IsLoggedIn == null)
                {
                    if (player.UserPassword == userPassword)
                    {
                        Console.WriteLine("Log In successfully!");
                        IsLoggedIn = player.UserName;
                    }
                }
                else
                {
                    Console.WriteLine("You are already logged in!");
                }
            }
            else
            {
                Console.WriteLine("Log In Failed!");   
            }
        }

        public void LogoutPlayer()
        {
                if (IsLoggedIn == null)
                {
                    Console.WriteLine("You are not logged in!");
                }
                else
                {
                    IsLoggedIn = null;
                    Console.WriteLine("Successfully logged out!");
                }
        }

        public void DeletePlayer(string userName)
        {
            _playerRepository.DeletePlayer(userName);
        }

        public string GetLog()
        {
            return IsLoggedIn;
        }
        public void ShowAllPlayers()
        {
            foreach (var player in _playerRepository.GetAllPlayers())
            {
                Console.WriteLine($"Player: {player.UserName}  |  AccountType: {player.AccountType}  |  Rating: {player.CurrentRating} ");
            }
        }

    }
}
