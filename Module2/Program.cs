using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  student
            Console.WriteLine("Student");
            Console.WriteLine("FirstName: ");
            string studentFirstName = Console.ReadLine();
            Console.WriteLine("Lastname: ");
            string studentLastName = Console.ReadLine();
            Console.WriteLine("Birthdate AAAA-MM-DD: ");
            string studentBirthdt = Console.ReadLine();
            DateTime studentBirthdate;
            studentBirthdate = DateTime.Parse(studentBirthdt);
            Console.WriteLine("Street Adress 1: ");
            string studentStreetAdress1 = Console.ReadLine();
            Console.WriteLine("Street Adress 2: ");
            string studentStreetAdress2 = Console.ReadLine();
            Console.WriteLine("City: ");
            string studentCity = Console.ReadLine();
            Console.WriteLine("State/Province: ");
            string studentState = Console.ReadLine();
            Console.WriteLine("Zip postal: ");
            string studentZip = Console.ReadLine();
            Console.WriteLine("Country: ");
            string studentCountry = Console.ReadLine();

            // Professor
            Console.WriteLine("FirstName: ");
            string professorFirstName = Console.ReadLine();
            Console.WriteLine("Lastname: ");
            string professorLastName = Console.ReadLine();
            Console.WriteLine("Birthdate AAAA-MM-DD: ");
            string professorBirthdt = Console.ReadLine();
            DateTime professorBirthdate;
            professorBirthdate = DateTime.Parse(professorBirthdt);
            Console.WriteLine("Street Adress 1: ");
            string professorStreetAdress1 = Console.ReadLine();
            Console.WriteLine("Street Adress 2: ");
            string professorStreetAdress2 = Console.ReadLine();
            Console.WriteLine("City: ");
            string professorCity = Console.ReadLine();
            Console.WriteLine("State/Province: ");
            string professorState = Console.ReadLine();
            Console.WriteLine("Zip postal: ");
            string professorZip = Console.ReadLine(); //May it can be int, but i think string its more accurate
            Console.WriteLine("Country: ");
            string professorCountry = Console.ReadLine();

            // Unviersity degrees

            string degreeName = "Bachelor of Science in Information Technology";
            int creditsRequired = 4;
            int difficulty = 8; //From 0 to 10

            // University Program

            string programName = "Computer Science";
            string degreesOffered = "Master, PhD, Bachelor"; // Cannot create arrays or lists
            string departmentHead = professorFirstName;


            Console.WriteLine("Student: " + studentFirstName + " " + studentLastName);
            Console.WriteLine("Birthdate: " + studentBirthdate.ToString());
            Console.WriteLine("Address: " + studentStreetAdress1 + " " + studentStreetAdress2);
            Console.WriteLine("Postal/ZIP: " + studentZip);
            Console.WriteLine("Country: " + studentCountry);
            Console.WriteLine("Province/State: " + studentState);
            Console.WriteLine("City: " + studentCity);
            Console.ReadKey();
        }
    }
}
