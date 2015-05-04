using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module7
{
    public class Course
    {
        private string name;
        private int credits;
        private ArrayList students;
        private ArrayList teachers;

        public Course(string name, int credits=0, ArrayList students=null, ArrayList teachers=null)
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

        public ArrayList Students
        {
            get { return students; }
            set { students = value; }
        }

        public ArrayList Teachers
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
