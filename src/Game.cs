﻿namespace ProjectT
{
    internal class Game
    {
        private string userInput ="";
        private readonly Actor player;
        private readonly List<Room> rooms = new List<Room>();

        public Game()
        {
            Room redRoom = new ("You are in the Red room. \nInput 2 to go to the blue room. \n");
            Room blueRoom = new ("You are in the Blue room. \nInput 1 to go to the red room.  \n ");

            rooms.Add(redRoom);
            rooms.Add(blueRoom);

            player = new Actor(redRoom);
        }

        public void Run()
        {
            while (true)
            {
                Utility.ClearScreen();
                player.GetCurrentRoom().DisplayRoomText();
                userInput = Utility.GetUserInput();
                Utility.PauseGame();

                if (userInput == "1" & player.GetCurrentRoom() != rooms[0])
                {
                    player.SetCurrentRoom(rooms[0]);
                }

                if (userInput == "2" & player.GetCurrentRoom() != rooms[0])
                {
                    Utility.DisplayText("You are already in the Red room. \n");
                }


                if (userInput == "2" & player.GetCurrentRoom() != rooms[1])
                {
                    player.SetCurrentRoom(rooms[1]);
                }

                if (userInput == "2" & player.GetCurrentRoom() != rooms[1])
                {
                    Utility.DisplayText("You are already in the Blue room \n");
                }
            }
        }
    }
}