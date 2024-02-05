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
    }
}
