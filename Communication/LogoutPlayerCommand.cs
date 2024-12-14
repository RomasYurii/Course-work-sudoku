using Course_work.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_work.Communication
{
    public class LogoutPlayerCommand : ICommand
    {
        private readonly IPlayerService _LogoutPlayerCommand;

        public LogoutPlayerCommand(IPlayerService playerService)
        {
            _LogoutPlayerCommand = playerService;
        }

        public void Execute()
        {
            try
            {
                _LogoutPlayerCommand.LogoutPlayer();

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid type.");
            }
        }

        public string GetDescription() => "Log out";
    }
}
