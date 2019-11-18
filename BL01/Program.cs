using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number Of Student: ");
            //ctrl + k + c: cmt
            //ctrl + k + u: uncmt
            //ctrl + k + d: format code
            int numOfStudent;
            try
            {
                numOfStudent = int.Parse(Console.ReadLine());
                InputStudentList(numOfStudent);
            }
            catch (Exception ex)
            {
                Console.Write("Invalid Input!");
                throw;
            }
            //dung man hinh de xem ket qua
            Console.ReadKey();
        }
        private static void InputStudentList(int numOfStudent)
        {
            //tao mang danh sach sinh vien
            Student[] studentList = new Student[numOfStudent];
            Student student;
            for (int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                Console.Write("ID = ");
                student.StudentID = int.Parse(Console.ReadLine());
                //tuong tu
                Console.Write("Name of Student: ");
                student.FullName = (Console.ReadLine());
                Console.Write("Mark: ");
                student.Mark = float.Parse(Console.ReadLine());
                Console.Write("Faculty: ");
                student.Faculty = (Console.ReadLine());
                //dua doi tuong vao mang
                studentList[i] = student;
            }
            // Export 
            Console.WriteLine("\n ====The list of student ====");
            Console.WriteLine("ID\t\tFullname\t\tMark\t\tFaculty");
            foreach (Student sv in studentList)
            {
                Console.WriteLine("\n");
                Console.WriteLine(" {0}\t{1}\t{2}\t{3}",sv.StudentID,sv.FullName,sv.Mark,sv.Faculty);

            }
            //De dung man hinh cho dễ kiểm tra kq
            Console.ReadKey();
        }
    }
}
