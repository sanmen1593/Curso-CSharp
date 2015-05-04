using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    public class Degree
    {
        private string name;
        private Course course;

        public Degree(string name, Course course=null)
        {
            this.name = name;
            this.course = course;
        }

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
