namespace ProjectT
{
    internal class Game
    {
        private bool isRunning = true;
        private string userInput ="";

        public void Run()
        {
            while (isRunning)
            {
                Console.WriteLine("Welcome to ProjectT. \n");
                Console.WriteLine("1. New game");
                Console.WriteLine("2. Quit");
                Console.WriteLine("");
                userInput = Console.ReadLine()!;

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Starting a new game.");
                        break;

                    case "2":
                        Console.WriteLine("Quitting game.");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
            }
        }
    }
}
