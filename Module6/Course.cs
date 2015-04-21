using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class Course
    {
        private string name;
        private int credits;
        private Student[] students;
        private Teacher[] teachers;

        public Course(string name, int credits=0, Student[] students=null, Teacher[] teachers=null)
        {
            this.name = name;
            this.credits = credits;
            this.students = students;
            this.teachers = teachers;
        }

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student[] Students
        {
            get { return students; }
            set { students = value; }
        }

        public Teacher[] Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }
    }
}
