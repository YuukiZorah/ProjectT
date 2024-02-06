namespace ProjectT
{
    internal static class Utility
    {
        public static void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public static void PauseGame()
        {
            Console.WriteLine("\n[Press any key to continue]");
            Console.ReadKey();
        }

        public static string GetUserInput()
        {
            return Console.ReadLine()!;
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }
    }
}
