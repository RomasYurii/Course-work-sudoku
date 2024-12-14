using Course_work.Communication;
using Course_work.Game;
using Course_work.Service;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_work
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Ініціалізація додатку
            ApplicationConfiguration.Initialize();

            // Створюємо консоль
            AllocConsole();

            // Налаштовуємо потоки для вводу/виводу в консоль
            StreamWriter standardOutput = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
            Console.SetOut(standardOutput);
            Console.SetError(standardOutput);

            StreamReader standardInput = new StreamReader(Console.OpenStandardInput());
            Console.SetIn(standardInput);

            // Ініціалізація залежностей
            var dbContext = new DbContext();
            var playerRepo = new PlayerRepository(dbContext);
            var playerService = new PlayerService(playerRepo);
            var commandMenu = new MenegmentCommand();

            var gameRepo = new GameRepository();
            var gameService = new GameService(gameRepo);    

            commandMenu.RegisterCommand(new AddPlayerCommand(playerService));
            commandMenu.RegisterCommand(new LoginPlayerCommand(playerService));
            commandMenu.RegisterCommand(new ShowAllPlayers(playerService));
            commandMenu.RegisterCommand(new ShowAllGames(gameService));
            commandMenu.RegisterCommand(new LogoutPlayerCommand(playerService));


            // Створюємо форму
            Form1 form = new Form1(playerService, playerRepo, gameRepo, gameService);

            // Запускаємо окремий потік для читання з консолі
            Task.Run(() => ReadConsoleInput(form, commandMenu));
            
            // Запускаємо форму
            Application.Run(form);
        }

        static void ReadConsoleInput(Form1 form, MenegmentCommand commandMenu)
        {
            while (true)
            {
                Console.WriteLine("---- Main Menu ----");
                commandMenu.ShowMenu();
                Console.WriteLine("\nEnter 0 to exit:");

                if (int.TryParse(Console.ReadLine(), out int commandNumber))
                {
                    //string commandNumber2 = commandNumber.ToString();
                    //form?.UpdateConsoleOutput(commandNumber2);

                    if (commandNumber == 0)
                    {
                        Console.WriteLine("Exiting...");
                        return;
                    }

                    commandMenu.ExecuteCommand(commandNumber);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid command.");
                }
            }
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
    }
}
