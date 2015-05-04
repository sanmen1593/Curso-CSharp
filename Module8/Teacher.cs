using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    public class Teacher : Person
    {
        
        private string title;

        public Teacher(string first_name, string last_name = "", string address = "", int age=18, string title=""):
            base(first_name,last_name,address,age)
        {
            this.title = title;
        }

        public void GradeTest()
        {
            Console.WriteLine("The teacher {0} {1} grade the exam", this.First_name, this.Last_name);
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
