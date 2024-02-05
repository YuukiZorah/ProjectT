namespace ProjectT
{
    internal class Game
    {
        private enum GameState { Exit, Intro, MainMenu };
        private GameState gameState = GameState.MainMenu;
        private string userInput ="";
        private readonly int waitTime = 1000;
 
        public void Run()
        {
            while (gameState == GameState.MainMenu)
            {
                Console.Clear();
                Console.WriteLine("Welcome to ProjectT. \n");
                Console.WriteLine("1. New game");
                Console.WriteLine("2. Quit");
                Console.WriteLine("");

                userInput = Console.ReadLine()!;

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Starting a new game.");
                        gameState = GameState.Intro;
                        userInput = "";
                        Thread.Sleep(waitTime);
                        break;

                    case "2":
                        Console.WriteLine("Quitting game.");
                        gameState = GameState.Exit;
                        Thread.Sleep(waitTime);
                        break;

                    default:
                        Console.WriteLine("Please enter a valid option");
                        userInput = "";
                        Thread.Sleep(waitTime);
                        break;
                }
            }

            while (gameState == GameState.Intro)
            { 
                Console.Clear();
                Console.WriteLine("It is a warm and sunny day, and you arrive at Hakone in good spirits. It is finally time for you to join the fight against the wretched Xenos.");
                Console.WriteLine("But before that a long and ardeous training regimen to become an MCU pilot awaits.");
                userInput = Console.ReadLine()!;
            }
        }
    }
}
