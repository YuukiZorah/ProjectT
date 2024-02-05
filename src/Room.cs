namespace ProjectT
{
    internal class Room
    {
        string RoomText = "";

        public Room(string roomText)
        {
            RoomText = roomText;
        }

        public void DisplayRoomText()
        {
            Utility.DisplayText(RoomText);
        }

        
    }
}
