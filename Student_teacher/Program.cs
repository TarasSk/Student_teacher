using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_teacher
{
    class Program
    {
        static void Main(string[] args)
        {
           var teacher = new List<Teacher>();

            teacher.Add(new Teacher() {Id = 1,Name = "Teacher 1", Students = new List<Student> {new Student() {Id = 1,Name = "First", Surname = "Student"}},Surname = "1111"});
            foreach (var teacher1 in teacher)
            {
                Console.WriteLine(teacher1.Id + " " + teacher1.Name);
                foreach (var student in teacher1.Students)
                {
                    Console.WriteLine(student.Id+" "+student.Name+" "+student.Surname);
                    Console.ReadLine();
                }
               
                Console.ReadLine();
            }
        }
    }
}
