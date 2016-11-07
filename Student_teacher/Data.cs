using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_teacher
{
    class Data
    {
        public Data()
        {
            _studenList = new List<Student>();
            _teacherList = new List<Teacher>();
        }

        public List<Student> StudentList
        {
            get { return _studenList; }
            set { _studenList = value; }
        }

        public List<Teacher> TeacherList
        {
            get { return _teacherList; }
        }
        private static List<Student>  _studenList;
        private static List<Teacher> _teacherList;
    }
}
