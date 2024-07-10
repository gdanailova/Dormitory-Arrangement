using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obshtejitie
{
    internal class Dormitory
    {
        public string Name {  get; set; }

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
            Console.WriteLine($"Стая {room.RoomNumber} добавена успешно.");
        }
        public void RemoveRoom(string roomNumber)
        {
            Room room = rooms.Find(r => r.RoomNumber == roomNumber);
            if (room != null)
            { rooms.Remove(room); 
                Console.WriteLine($"Стая {roomNumber} премахната успешно"); 
            }
            else
            { 
                Console.WriteLine($"Стая {roomNumber} не съществува");
            }
        }

        public Room SearchRoomByNumber(string roomNumber)
        {
            return rooms.Find(r => r.RoomNumber == roomNumber);
        }
        public void ListAllRooms()
        {
            Console.WriteLine("Всички стаи:");
            foreach (var room in rooms)
            {
                Console.WriteLine($"Стая {room.RoomNumber}-Етаж: {room.Floor}, Вместимост: {room.Capacity}, Заети легла: {room.OccupiedBeds}, Свободни: {room.IsAvailable}");
            }
        }
        public void RegisterStudent(Student student)
        {
           students.Add(student);
            Console.WriteLine($"Студент {student.FullName} регистриран успешно");
        }

        public void AssignRoom(string studentID, string roomNumber)
        {
            Student student = students.Find(s => s.StudentID == studentID);
            Room room = rooms.Find(r => r.RoomNumber == roomNumber);
            if (student != null && room != null && room.IsAvailable)
            {
                student.RoomNumber = roomNumber; room.OccupiedBeds++;
                Console.WriteLine($"Студент {student.FullName} настанен в стая {roomNumber}.");
            }
            else { Console.WriteLine("Грешка: Настаняването в стая се провали"); }
        }

        public void VacateRoom(string studentID)
        {
            Student student = students.Find(s => s.StudentID == studentID);
            if (student != null && student.RoomNumber != null)
            {
                Room room = rooms.Find(r => r.RoomNumber == student.RoomNumber);
                room.OccupiedBeds--; student.RoomNumber = null;
                Console.WriteLine($"Студент { student.FullName} освободи стая { room.RoomNumber}.");
            }
            else 
            { 
                Console.WriteLine("Грешка: Освобожаването на стая се провали"); 
            }
        }
        public void GenerateReport()
        {
            Console.WriteLine("Репорт на общежитие:");
            foreach (var room in rooms)
            {
                Console.WriteLine($"Стая {room.RoomNumber}: {room.OccupiedBeds}/{room.Capacity} заети легла");
            }
        }

    }
}
