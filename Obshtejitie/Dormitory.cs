using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Obshtejitie
{
    internal class Dormitory
    { 
        public string Name { get; set; }

        public string Address { get; set; }
        public string Manager { get; set; }

        private List<Room> rooms = new List<Room>(); private List<Student> students = new List<Student>();
        public Dormitory(string name, string address, string manager)
        {
            Name = name;
            Address = address;
            Manager = manager;
        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Стая {room.RoomNumber} добавена успешно.");
            Console.ReadLine();
        }
        public void RemoveRoom(string roomNumber)
        {
            Room room = rooms.Find(r => r.RoomNumber == roomNumber);
            if (room != null)
            {
                rooms.Remove(room);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Стая {roomNumber} премахната успешно");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Стая {roomNumber} не съществува");
                Console.ReadLine();
            }
        }

        public Room SearchRoomByNumber(string roomNumber)
        {
            return rooms.Find(r => r.RoomNumber == roomNumber);
        }
        public void ListAllRooms()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Всички стаи:");
            foreach (var room in rooms)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Стая {room.RoomNumber}-Етаж: {room.Floor}, Вместимост: {room.Capacity}, Заети легла: {room.OccupiedBeds}, Свободни: {room.IsAvailable}");
                Console.ReadLine();
            }
        }
        public void RegisterStudent(Student student)
        {
            students.Add(student);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Студент {student.FullName} регистриран успешно");
            Console.ReadLine();
        }

        public void AssignRoom(string studentID, string roomNumber)
        {
            Student student = students.Find(s => s.StudentID == studentID);
            Room room = rooms.Find(r => r.RoomNumber == roomNumber);
            if (student != null && room != null && room.IsAvailable)
            {
                student.RoomNumber = roomNumber; room.OccupiedBeds++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Студент {student.FullName} настанен в стая {roomNumber}.");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Грешка: Настаняването в стая се провали");
                Console.ReadLine();
            }
        }

        public void VacateRoom(string studentID)
        {
            Student student = students.Find(s => s.StudentID == studentID);
            if (student != null && student.RoomNumber != null)
            {
                Room room = rooms.Find(r => r.RoomNumber == student.RoomNumber);
                room.OccupiedBeds--; student.RoomNumber = null;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Студент {student.FullName} освободи стая {room.RoomNumber}.");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Грешка: Освобожаването на стая се провали");
                Console.ReadLine();
            }
        }
        public void GenerateReport()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Репорт на общежитие:");
            foreach (var room in rooms)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Стая {room.RoomNumber}: {room.OccupiedBeds}/{room.Capacity} заети легла");
                Console.ReadLine();
            }
        }

    }
}
