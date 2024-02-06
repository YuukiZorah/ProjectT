namespace ProjectT
{
    internal class Room(string roomText)
    {
        private readonly string RoomText = roomText;

        public void DisplayRoomText()
        {
            Utility.DisplayText(RoomText);
        }
        
        public string GetRoomText()
        {
            return RoomText;
        }
    }
}
