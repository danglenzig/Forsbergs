namespace TextAdventureLab
{
    class Room
    {
        
        private string roomName;
        public string RoomName
        {
            get => roomName;
            set
            {
                roomName = value;
            }
        }
        
        private string roomDescription;
        public string RoomDescription
        {
            get => roomDescription;
            set
            {
                roomDescription = value;
            }
        }
        
        private bool hasForward;
        public bool HasForward
        {
            get => hasForward;
            set
            {
                hasForward = value;
            }
        }
        private Room forwardRoom = null;
        
        private bool hasBackward;
        public bool HasBackward
        {
            get => hasBackward;
            set
            {
                hasBackward = value;
            }
        }
        private Room backwardRoom = null;
        
        private bool hasLeft;
        public bool HasLeft
        {
            get => hasLeft;
            set
            {
                hasLeft = value;
            }
        }
        private Room leftRoom = null;
        
        private bool hasRight;
        public bool HasRight
        {
            get => hasRight;
            set
            {
                hasRight = value;
            }
        }
        private Room rightRoom = null;
        
        

        public Room(string _roomName)
        {
            RoomName = _roomName;
        }

        public void ConnectDirectionToRoom(string _direction, Room _connectedRoom)
        {
            switch (_direction)
            {
                case "FORWARD":
                    if (!hasForward)
                    {
                        Console.WriteLine($"{RoomName} has no forward exit");
                        return;
                    }
                    forwardRoom = _connectedRoom;
                    break;
                case "BACKWARD":
                    if (!hasBackward)
                    {
                        Console.WriteLine($"{RoomName} has no backward exit");
                        return;
                    }
                    backwardRoom = _connectedRoom;
                    break;
                case "LEFT":
                    if (!hasLeft)
                    {
                        Console.WriteLine($"{RoomName} has no left exit");
                        return;
                    }
                    leftRoom = _connectedRoom;
                    break;
                case "RIGHT":
                    if (!hasRight)
                    {
                        Console.WriteLine($"{RoomName} has no right exit");
                        return;
                    }
                    rightRoom = _connectedRoom;
                    break;
            }
        }
        
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("hello, World!");
        }
    }
}

