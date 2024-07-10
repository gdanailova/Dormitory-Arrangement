using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Obshtejitie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dormitory dormitory = new Dormitory("Общежитие А", "ул. Стефан Стамболов 15", "Яким Хаджирадев");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Система за упревление на общежитие");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1.Добавяне на стая");
                Console.WriteLine("2.Премахване на стая");
                Console.WriteLine("3.Търсене на стая от номер");
                Console.WriteLine("4.Списък със всички стаи:");
                Console.WriteLine("5.Регистриране на студент");
                Console.WriteLine("6.Настаняване на студент в стая");
                Console.WriteLine("7.Освобождаване на стая");
                Console.WriteLine("8.Генериране на репорт");
                Console.WriteLine("9.Изход");
                Console.Write("Изберете опция: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Въведете номер на стая: ");
                        string roomNumber = Console.ReadLine();
                        Console.Write("Въведете етаж: ");
                        int floor = int.Parse(Console.ReadLine());
                        Console.Write("Въведете вместимост: ");
                        int capacity = int.Parse(Console.ReadLine());
                        dormitory.AddRoom(new Room(roomNumber, floor, capacity));
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Въведете номер на стая за премахване: ");
                        roomNumber = Console.ReadLine();
                        dormitory.RemoveRoom(roomNumber);
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Въведете номер на стая за търсене: ");
                        roomNumber = Console.ReadLine(); Room room = dormitory.SearchRoomByNumber(roomNumber);
                        if (room != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"Стая {room.RoomNumber} -Етаж: {room.Floor}, Вместимост: {room.Capacity}," +
                            $" Заети легла: {room.OccupiedBeds}, Свободни: {room.IsAvailable}");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Стаята не е намерена");
                            Console.ReadLine();
                        }
                        break;
                    case "4":
                        dormitory.ListAllRooms();
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Въведете ID на студент: ");
                        string studentID = Console.ReadLine();
                        Console.Write("Въведете име на студент: ");
                        string fullName = Console.ReadLine();
                        dormitory.RegisterStudent(new Student(studentID, fullName));
                        break;
                    case "6":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Въведете ID на студент: ");
                        studentID = Console.ReadLine();
                        Console.Write("Въведете номер на стая: ");
                        roomNumber = Console.ReadLine();
                        dormitory.AssignRoom(studentID, roomNumber);
                        break;
                    case "7":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Въведете ID на студент: ");
                        studentID = Console.ReadLine();
                        dormitory.VacateRoom(studentID);
                        break;
                    case "8":
                        dormitory.GenerateReport();
                        break;
                    case "9": return;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Грешна опция. Моля опитайте отново");
                        Console.ReadLine();
                        break;
                }

            }
        }
    }
}