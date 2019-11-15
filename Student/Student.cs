using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public int MyProperty { get; set; }
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public float Mark  { get;  }
        public string Faculty { get; set; }
        public int StrudentID { get => studentID; set => StudentID; value; }
        private int studentID;
        public Student()
        {

        }

        public Student(int studentID, string fullName, float mark,string faculty)
        {
            StudentID = studentID;
            FullName = fullName;
            Mark = Mark;
            Faculty = faculty;
        }
    }
}
