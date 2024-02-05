namespace ProjectT
{
    internal class Game
    {
        private enum GameState { Exit, Intro, MainMenu };
        private GameState gameState = GameState.MainMenu;
        private string userInput ="";
        

        public void Run()
        {
            while (gameState == GameState.MainMenu)
            {
                Console.Clear();
                Utility.DisplayText("Welcome to ProjectT. \n");
                Utility.DisplayText("1. New game");
                Utility.DisplayText("2. Quit\n");

                userInput = Console.ReadLine()!;

                switch (userInput)
                {
                    case "1":
                        Utility.DisplayText("Starting a new game.");
                        gameState = GameState.Intro;
                        userInput = "";
                        Utility.PauseGame();
                        break;

                    case "2":
                        Utility.DisplayText("Quitting game.");
                        gameState = GameState.Exit;
                        Utility.PauseGame();
                        Environment.Exit(0);
                        break;

                    default:
                        Utility.DisplayText("Please enter a valid option");
                        userInput = "";
                        Utility.PauseGame();
                        break;
                }
            }

            while (gameState == GameState.Intro)
            { 
                Console.Clear();
                Utility.DisplayText("It is a warm and sunny day, and you arrive at Hakone in good spirits. It is finally time for you to join the fight against the wretched Xenos.");
                Utility.DisplayText("But before that a long and ardeous training regimen to become an MCU pilot awaits.");

                userInput = Console.ReadLine()!;

                switch (userInput)
                {

                }
            }
        }
    }
}
