using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class Student : Person
    {
        private static int total_students=0;

        public Student(string first_name, string last_name = "", string address = "", int age = 18):
            base(first_name, last_name, address, age)
        {
            total_students += 1;
        }

        public void TakeTest()
        {
            Console.WriteLine("The student {0} {1} took de examen.", this.First_name, this.Last_name);
        }

        public static int Total_students
        {
            get { return Student.total_students; }
            set { Student.total_students = value; }
        }
    }
}
