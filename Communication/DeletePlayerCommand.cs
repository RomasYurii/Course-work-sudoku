using Course_work.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_work.Communication
{
    public class DeletePlayerCommand : ICommand
    {
        private readonly IPlayerService _DeletePlayerCommand;

        public DeletePlayerCommand(IPlayerService playerService)
        {
            _DeletePlayerCommand = playerService;
        }

        public void Execute()
        {
            try
            {
                Console.Write("Enter player name to delete: ");
                string playerName = Console.ReadLine();

                Console.Write("Enter player`s password: ");
                string playerPassword = Console.ReadLine();

                _DeletePlayerCommand.DeletePlayer(playerName, playerPassword);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid type.");
            }
        }

        public string GetDescription() => "Delete player";
    }
}
