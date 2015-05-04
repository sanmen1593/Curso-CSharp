using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module7
{
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

            ArrayList students = new ArrayList();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            // 3. Add your three students to this Course object.
            course_c_sharp.Students = students; 

            // 4. Instantiate at least one Teacher object.
            Teacher teacher = new Teacher("Jairo", "Serrano", "Ternera", 30);
            ArrayList teachers = new ArrayList();

            teachers.Add(teacher);

            // 5. Add that Teacher object to your Course object
            course_c_sharp.Teachers = teachers;

            course_c_sharp.ListStudents();
            Console.ReadKey();
        }
    }
}
