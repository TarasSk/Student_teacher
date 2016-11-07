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
            var menu = new MenuActions();
            var data = new Data();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine();
                Console.Clear();

                Console.WriteLine("1. Add new teacher");
                Console.WriteLine("2. Show students sorted by Name: ");
                Console.WriteLine("3. Delete teacher by ID");
                Console.WriteLine("4. Delete student by Name");
                Console.WriteLine("5. Exit");

                Console.WriteLine("");
                int key = 0;

                try
                {
                    key = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {   
                    Console.WriteLine("Invalid command");
                    Console.ReadKey();
                }
              

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
