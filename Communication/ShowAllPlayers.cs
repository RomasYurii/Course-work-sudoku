using Course_work.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_work.Communication
{
    public class ShowAllPlayers : ICommand
    {
        private readonly IPlayerService _ShowAllPlayers;

        public ShowAllPlayers(IPlayerService playerService)
        {
            _ShowAllPlayers = playerService;
        }

        public void Execute()
        {
            try
            {
                _ShowAllPlayers.ShowAllPlayers();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid type.");
            }
        }

        public string GetDescription() => "Show all players";
    }
}
