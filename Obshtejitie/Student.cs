using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obshtejitie
{
    internal class Student
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public string RoomNumber { get; set; } 
        public Student(string studentID, string fullName)
        {
            StudentID = studentID;
            FullName = fullName;
            RoomNumber = null;
        } 
    }
    
}
