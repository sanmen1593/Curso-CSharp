using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module8
{
    public class Course
    {
        private string name;
        private int credits;
        private List<Student> students;
        private List<Teacher> teachers;

        public Course(string name, int credits = 0, List<Student> students = null, List<Teacher> teachers = null)
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

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        public void ListStudents()
        {
            foreach (Student student in this.students)
            {
                Console.WriteLine("{0} {1}", student.First_name, student.Last_name);
            }
        }
    }
}
