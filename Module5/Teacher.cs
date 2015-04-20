using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    public class Teacher
    {
        private string first_name;
        private string last_name;
        private string address;
        private int age;
        private string title;

        public Teacher(string first_name, string last_name = "", string address = "", int age=18)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
            this.age = age;
        }

        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
