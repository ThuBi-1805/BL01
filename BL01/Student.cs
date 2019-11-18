using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL01
{
    class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public float Mark { get; set; }
        public string Faculty { get; set; }

        public Student()
        {

        }

        public Student(int studentID, string fullName, float mark, string faculty)
        {
            StudentID = studentID;
            FullName = fullName;
            Mark = Mark;
            Faculty = faculty;
        }
    }
}
