using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    public class Student
    {
        private string first_name;
        private string last_name;
        private string address;
        private int age;
        private static int total_students=0;

        public Student(string first_name, string last_name = "", string address = "", int age=18)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
            this.age = age;
            total_students += 1;
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

        public static int Total_students
        {
            get { return Student.total_students; }
            set { Student.total_students = value; }
        }
    }
}
