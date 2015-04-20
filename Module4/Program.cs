using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public class Program
    {
        struct Student
        {
            string firstName;
            string lastName;
            string birthdate;

            public Student(string firstname, string lastname, string birthdate)
            {
                this.firstName = firstname;
                this.lastName = lastname;
                this.birthdate = birthdate;
            }

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; } 
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public string Birthdate
            {
                get { return birthdate; }
                set { birthdate = value; }
            }
        }

        struct Teacher
        {
            string firstName;
            string lastName;
            string birthdate;

            public Teacher(string firstname, string lastname, string birthdate)
            {
                this.firstName = firstname;
                this.lastName = lastname;
                this.birthdate = birthdate;
            }

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public string Birthdate
            {
                get { return birthdate; }
                set { birthdate = value; }
            }
        }

        struct Programs
        {
            string name;
            string university;
            int totalCredits;

            public Programs(string name, string university, int credits)
            {
                this.name = name;
                this.university = university;
                this.totalCredits = credits;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string University
            {
                get { return university; }
                set { university = value; }
            }

            public int TotalCredits
            {
                get { return totalCredits; }
                set { totalCredits = value; }
            }
        }

        struct Course
        {
            string name;
            string university;
            int totalCredits;
            Programs program;

            public Course(string name, string university, int totalCredits, Programs program)
            {
                this.name = name;
                this.university = university;
                this.totalCredits = totalCredits;
                this.program = program;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string University
            {
                get { return university; }
                set { university = value; }
            }

            public int TotalCredits
            {
                get { return totalCredits; }
                set { totalCredits = value; }
            }

            public Programs Program
            {
                get { return program; }
                set { program = value; }
            }
        }


        static void Main(string[] args)
        {
            Student student1 = new Student("Santiago", "Mendoza", "1993-10-15");
            Student student2 = new Student("Ruben", "Melo", "1993-11-15");
            Student student3 = new Student("Jairo", "Serrano", "1993-12-15");
            Student student4 = new Student("Alfredo", "Ardila", "1993-13-15");
            Student student5 = new Student("Gustavo", "Mendoza", "1993-14-15");

            Student[] students = {student1, student2, student3, student4, student5};
            foreach(Student student in students){
                Console.WriteLine("{0} {1} birthday is on {2}", student.FirstName, student.LastName, student.Birthdate);
            }
            Console.ReadKey();

        }
    }
}
