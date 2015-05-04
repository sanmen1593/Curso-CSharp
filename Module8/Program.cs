using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module8Condensed
{
    public class Person
    {
        private string first_name;

        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }
        private string last_name;

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string first_name, string last_name = "", string address = "", int age = 18)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
            this.age = age;
        }
    }

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

    public class Student : Person
    {
        private static int total_students = 0;
        private Stack<float> grades = new Stack<float>();

        public Stack<float> Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        public Student(string first_name, string last_name = "", string address = "", int age = 18) :
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

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Santiago", "Mendoza", "Manga", 21);
            Student student2 = new Student("Ruben", "Melo", "Torices", 23);
            Student student3 = new Student("Cesar", "De la Hoz", "Cartagena", 24);

            student1.Grades.Push(5);
            student1.Grades.Push(4);
            student1.Grades.Push(3);
            student1.Grades.Push(4);
            student1.Grades.Push(5);
            student2.Grades.Push(4);
            student2.Grades.Push(2);
            student2.Grades.Push(3);
            student2.Grades.Push(2);
            student2.Grades.Push(4);
            student3.Grades.Push(3);
            student3.Grades.Push(2);
            student3.Grades.Push(1);
            student3.Grades.Push(1);
            student3.Grades.Push(1);

            Course course_c_sharp = new Course("Programming with C#", 4);

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            // 3. Add your three students to this Course object.
            course_c_sharp.Students = students; 

            // 4. Instantiate at least one Teacher object.
            Teacher teacher = new Teacher("Jairo", "Serrano", "Ternera", 30);
            List<Teacher> teachers = new List<Teacher>();

            teachers.Add(teacher);

            // 5. Add that Teacher object to your Course object
            course_c_sharp.Teachers = teachers;

            course_c_sharp.ListStudents();
            Console.ReadKey();
        }
    }
}
