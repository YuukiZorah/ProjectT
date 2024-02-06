namespace ProjectT
{
    internal class Actor(Room room)
    {
        private Room currentRoom = room;

        public void Move(Room DestinationRoom)
        {
            currentRoom = DestinationRoom;
        }

        public Room GetCurrentRoom()
        {
            return currentRoom;
        }

        public void SetCurrentRoom(Room newRoom)
        {
            currentRoom = newRoom;
        }
    }
}
