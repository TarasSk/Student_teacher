using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Student_teacher
{
    class Student
    {
        public Student()
        {
        }
        public Int32 Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String Surname
        {
            get { return _surname; }    
            set { _surname = value; }
        }

        private Int32 _id;
        private String _name;
        private String _surname;
    }
}
