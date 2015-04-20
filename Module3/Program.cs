using System;

namespace Module3
{
    class Program
    {
        /// <summary>
        /// Get Students info and then call function to print it into console.
        /// </summary>
        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Birthdate AAAA-MM-DD: ");
            string studentBirthdt = Console.ReadLine();
            PrintStudentDetails(firstName, lastName, studentBirthdt);
        }

        /// <summary>
        /// Print student info into console.
        /// </summary>
        /// <param name="first">Student's first name</param>
        /// <param name="last">Student's last name</param>
        /// <param name="birthday">Student's birthday</param>
        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        /// <summary>
        /// Get Teacher info and then call function to print it into console.
        /// </summary>
        static void GetTeacherInfo()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Birthdate AAAA-MM-DD: ");
            string studentBirthdt = Console.ReadLine();
            PrintTeacherDetails(firstName, lastName, studentBirthdt);
        }

        /// <summary>
        /// Print teacher info into console.
        /// </summary>
        /// <param name="first">Teacher's first name</param>
        /// <param name="last">Teacher's last name</param>
        /// <param name="birthday">Teacher's birthday</param>
        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        /// <summary>
        /// Get program info and then call function to print into console.
        /// </summary>
        static void GetProgramInfo()
        {
            Console.WriteLine("Enter the program's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Director: ");
            string director = Console.ReadLine();
            Console.WriteLine("Enter the program's credits: ");
            int credits;
            credits = Convert.ToInt32(Console.ReadLine());
            PrintProgramDetails(name, director, credits);
        }

        /// <summary>
        /// Print program info into console.
        /// </summary>
        /// <param name="name">Program's name.</param>
        /// <param name="teacher">Name of program's director.</param>
        /// <param name="credits">Program's total credits</param>
        static void PrintProgramDetails(string name, string teacher, int credits)
        {
            Console.WriteLine("The program's director of {0} is {1} and have {2} credits", name, teacher, credits.ToString());
        }

        static bool ValidateBirthDate(string Birthdate)
        {
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetTeacherInfo();
            GetProgramInfo();
            ValidateBirthDate("1993-10-15");

            Console.ReadKey();
        }
    }
}
