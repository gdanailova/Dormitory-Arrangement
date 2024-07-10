using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obshtejitie
{
    internal class Room
    {
        public string RoomNumber { get; set; }
        public int Floor { get; set; }
        public int Capacity { get; set; }
        public int OccupiedBeds { get; set; }
        public bool IsAvailable { get { return OccupiedBeds < Capacity; } }
        public Room(string roomNumber, int floor, int capacity)
        {
            RoomNumber = roomNumber; Floor = floor; Capacity = capacity; OccupiedBeds = 0;
        }
    }
}
    
