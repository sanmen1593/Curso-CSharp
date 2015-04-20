using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Instantiate three Student objects.
            Student student1 = new Student("Santiago", "Mendoza", "Manga", 21);
            Student student2 = new Student("Ruben", "Melo", "Torices", 23);
            Student student3 = new Student("Cesar", "De la Hoz", "Cartagena", 24);

            // 2. Instantiate a Course object called Programming with C#.
            Course course_c_sharp = new Course("Programming with C#", 4);

            Student[] students = new Student[3];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

            // 3. Add your three students to this Course object.
            course_c_sharp.Students = students; 

            // 4. Instantiate at least one Teacher object.
            Teacher teacher = new Teacher("Jairo", "Serrano", "Ternera", 30);
            Teacher[] teachers = new Teacher[1];

            // 5. Add that Teacher object to your Course object
            course_c_sharp.Teachers = teachers;

            // 6. Instantiate a Degree object, such as Bachelor.
            Degree degree = new Degree("Bachelor of Science");

            // 7. Add your Course object to the Degree object.
            degree.Course = course_c_sharp;

            // 8. Instantiate a UProgram object called Information Technology.
            UProgram program = new UProgram("Information Technology", "Universidad Tecnológica de Bolívar");

            // 9. Add the Degree object to the UProgram object.
            program.Degree = degree;

            /* 10. sing Console.WriteLine statements, output the following information to the console window:
                The name of the program and the degree it contains
                The name of the course in the degree
                The count of the number of students in the course.
                Your output should look similar to this:
            */

            Console.WriteLine("The {0} program contains the {1} degree", program.Name, program.Degree.Name);
            Console.WriteLine("The {0} degree contains the course {1}", program.Degree.Name, program.Degree.Course.Name);
            Console.WriteLine("The {0} course contains {1} students", program.Degree.Course.Name, Student.Total_students);
            Console.ReadKey();
        }
    }
}
