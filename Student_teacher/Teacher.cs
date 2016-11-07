using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_teacher
{
    class Teacher
    {
        public Teacher(Int32 id, String name, String surname, List<Student> students)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _students = students;
        }
        private Int32 _id;
        private String _name;
        private String _surname;
        private List<Student> _students;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }
    }
}
