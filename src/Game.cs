namespace ProjectT
{
    internal class Game
    {
        private enum GameState { MainMenu, Exit };
        private GameState gameState = GameState.MainMenu;
        private string userInput ="";

        public void Run()
        {
            DisplayMainMenu();

            while (gameState != GameState.Exit)
            {
                MainMenu();
            }
        }

        public static void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to ProjectT. \n");
            Console.WriteLine("1. New game");
            Console.WriteLine("2. Quit");
            Console.WriteLine("");
        }

        public void MainMenu()
        {
            userInput = Console.ReadLine()!;

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Starting a new game.");
                    break;

                case "2":
                    Console.WriteLine("Quitting game.");
                    gameState = GameState.Exit;
                    break;

                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
        }
    }
}
