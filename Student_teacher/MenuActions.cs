using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_teacher
{
    class MenuActions
    {
        public void AddTeacher(List<Teacher> teachers)
        {
            char key = '\0';
           
                _teacherId++;
                Console.Clear();
                Console.WriteLine("Add new teacher: ");
                Console.WriteLine("Please, type teacher name: ");
                string teacherName = Console.ReadLine();
                Console.WriteLine("Please, type teacher surname: ");
                string teacherSurname = Console.ReadLine();
                _students = new List<Student>();

            do
                {
                  
                    Console.Clear();
                    _studenId++;
                    Console.WriteLine("Please, type student name: ");
                    string studentName = Console.ReadLine();
                    Console.WriteLine("Please, type student surname: ");
                    string studentSurname = Console.ReadLine();
                    _students.Add(new Student(_studenId, studentName, studentSurname));
                    Console.WriteLine("Add another student? Y/N");
                    var readLine = Console.ReadLine();
                    if (readLine != null) key = readLine[0];
                } while (key == 'y' || key == 'Y');

                teachers.Add(new Teacher(_teacherId, teacherName, teacherSurname, _students));
            
        }

        public void DeleteTeacherByID(List<Teacher> teachers)
        {
            Console.Clear();
            Console.WriteLine("Please, type id: ");
            int teacherId = Convert.ToInt32(Console.ReadLine());

            teachers.RemoveAll(x => x.Id.Equals(teacherId));

        }

        public void DeleteStudentByName(List<Teacher> teachers)
        {
            Console.Clear();
            Console.WriteLine("Please, type name: ");
            string name = Console.ReadLine();
            foreach (var teacher in teachers)
            {
                teacher.Students.RemoveAll(x => x.Name.Equals(name));
            }
        }

        public void Show(List<Teacher> teachers)
        {
            //var sortedlist = from teacher in teachers
            //    from student in teacher.Students
            //    orderby student descending
            //    select teacher;
              
            Console.Clear();
            foreach (var th in teachers)
            {
                Console.WriteLine("Teacher ID: "+th.Id + "\t Teacher Name: " + th.Name+"\t Teacher Surname: "+th.Surname);
                Console.WriteLine();
                var sortedstud = th.Students.OrderBy(x => x.Name);
                foreach (var st in sortedstud)
                {
                    Console.WriteLine("Student ID: "+st.Id + "\t Student Name: " + st.Name + "\t Student Surname: " + st.Surname);
                }
                Console.ReadLine();
            }
        }

        private Int32 _studenId;
        private Int32 _teacherId;
        private List<Student> _students;
    }
}
