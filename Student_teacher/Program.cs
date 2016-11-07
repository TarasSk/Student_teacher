using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_teacher
{
    class Program
    {
        static void Main(string[] args)
        {
           //var teacher = new List<Teacher>();

           // teacher.Add(new Teacher() {Id = 1,Name = "Teacher 1", Students = new List<Student> {new Student() {Id = 1,Name = "First", Surname = "Student"}},Surname = "1111"});
           // foreach (var teacher1 in teacher)
           // {
           //     Console.WriteLine(teacher1.Id + " " + teacher1.Name);
           //     foreach (var student in teacher1.Students)
           //     {
           //         Console.WriteLine(student.Id+" "+student.Name+" "+student.Surname);
           //         Console.ReadLine();
           //     }
               
           //     Console.ReadLine();
           // }
            var menu = new MenuActions();
            var data = new Data();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine();
                Console.Clear();

                Console.WriteLine("1. Add new teacher");
                Console.WriteLine("2. Show students");
                Console.WriteLine("3. Delete teacher by ID");
                Console.WriteLine("4. Delete student by Name");
                Console.WriteLine("5. Exit");

                Console.WriteLine("");

                int key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1: menu.AddTeacher(data.TeacherList);
                    break;
                    case 2: menu.Show(data.TeacherList);
                    break;
                    case 3: menu.DeleteTeacherByID(data.TeacherList);
                    break;
                    case 4: menu.DeleteStudentByName(data.TeacherList);
                    break;
                    case 5:
                        exit = true;
                        break;
                    default:
                    Console.WriteLine("Invalid command");
                    Console.ReadKey();
                    break;
                }
            }








        }
    }
}
