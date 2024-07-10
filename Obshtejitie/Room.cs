using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obshtejitie
{
    internal class Room
    {
        public string roomNumber;
        private int floor;
        private int capacity;
        private int occupiedBeds;
        private bool isAvailable;

        public string RoomNumber
        {
            get { return roomNumber; }
            set
            {
                int RoomNum = Convert.ToInt32(RoomNumber);               
                else if (RoomNum <= 0 || RoomNum > 30)
                {
                    throw new ArgumentException("Номерът на стаята не може да бъде повече от 30 или отрицателно число.");
                }
                roomNumber = value;
            }
        }
        public int Floor
        {
            get { return floor; }
            set
            {
                if (floor < 0 || floor > 3)
                {
                    throw new ArgumentException("Номерът на етажа не може да бъде отрицателен или повече от 3");
                }
                floor = value;
            }
        }
        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (capacity <= 0)
                {
                    throw new ArgumentException("Капацитетът не може да бъде отрицателно число или празно място.");
                }
                if (capacity > 2)
                {
                    throw new ArgumentException("Капацитетът не може да бъде повече от 2 човека в стая.");
                }
                capacity = value;
            }
        }
        public int OccupiedBeds
        {
            get { return occupiedBeds; }
            set
            {
                if (occupiedBeds < 0)
                {
                    throw new ArgumentException("Заетите легла не могат да са отрицателно число.");
                }
                if (occupiedBeds > 2)
                {
                    throw new ArgumentException("Заетите легла не могат да бъдат повече от 2 на стая.");
                }
                occupiedBeds = value;
            }
        }
        public bool IsAvailable
        {
            get
            { return isAvailable; }

            set
            {
                if (occupiedBeds == 2)
                {
                    isAvailable = false;
                    Console.WriteLine("Стаята е заета.");
                }
                else
                {
                    Console.WriteLine("В стаята има място.");
                }
                isAvailable = true;
            }
        }
        public Room(string roomNumber, int floor, int capacity)
        {
            RoomNumber = roomNumber;
            Floor = floor;
            Capacity = capacity;
            OccupiedBeds = 0;
        }
    }
    
}

    
