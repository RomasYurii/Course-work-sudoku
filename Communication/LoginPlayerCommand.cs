using Course_work.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course_work.Service;

namespace Course_work
{
    public class LoginPlayerCommand : ICommand
    {
        private readonly IPlayerService _LoginPlayerCommand;

        public LoginPlayerCommand(IPlayerService playerService)
        {
            _LoginPlayerCommand = playerService;
        }

        public void Execute()
        {
            try
            {
                Console.Write("Enter your name: ");
                string playerName = Console.ReadLine();

                Console.Write("Enter your password: ");
                string playerPassword = Console.ReadLine();

                _LoginPlayerCommand.LoginPlayer(playerName, playerPassword);


            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid type.");
            }
        }

        public string GetDescription() => "Login";
    }
}
