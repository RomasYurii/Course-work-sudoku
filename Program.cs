using Course_work.Communication;
using Course_work.Service;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Course_work
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Form1 form = new Form1();

            // Створюємо консоль
            AllocConsole();

            // Пов'язуємо стандартний потік із консоллю
            StreamWriter standardOutput = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
            Console.SetOut(standardOutput);
            Console.SetError(standardOutput);

            StreamReader standardInput = new StreamReader(Console.OpenStandardInput());
            Console.SetIn(standardInput);

            var dbContext = new DbContext();
            var playerRepo = new PlayerRepository(dbContext);

            var playerService = new PlayerService(playerRepo);
            var commandMenu = new MenegmentCommand();
            commandMenu.RegisterCommand(new AddPlayerCommand(playerService));

            // Запускаємо окремий потік для читання з консолі
            Task.Run(() => ReadConsoleInput(form, commandMenu));

            Console.WriteLine("444");

           // var dbContext = new DbContext();
           // var playerRepo = new PlayerRepository(dbContext);

           // var playerService = new PlayerService(playerRepo);

           // var commandMenu = new MenegmentCommand();

            //commandMenu.RegisterCommand(new ShowPlayerInfoCommand(playerService));
            //commandMenu.RegisterCommand(new AddPlayerCommand(playerService));
            //commandMenu.RegisterCommand(new ShowAllPlayersCommand(playerService));
            //commandMenu.RegisterCommand(new PlayGameCommand(gameService));


            // Запускаємо форму

            Application.Run(form);

        }
        // Метод для читання тексту з консолі
        static void ReadConsoleInput(Form1 form, MenegmentCommand commandMenu)
        {
            while (true)
            {
                Console.WriteLine("---- Main Menu ----");
                commandMenu.ShowMenu();
                Console.WriteLine("\nEnter 0 to exit:");

                int commandNumber = int.Parse(Console.ReadLine());

                string commandNumber2 = commandNumber.ToString();
                form?.UpdateConsoleOutput(commandNumber2);
                if (commandNumber == 0)
                {
                    return;
                }

                commandMenu.ExecuteCommand(commandNumber);


            }
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
    }
}