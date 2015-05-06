using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
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
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string first_name, string last_name = "", string city = "", int age = 18)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.city = city;
            this.age = age;
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

        public Student(string first_name, string last_name = "", string city = "", int age = 18) :
            base(first_name, last_name, city, age)
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

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        int posicionInList = -1;

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            string name = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string city = txtCity.Text;

            Student student = new Student(name, lastname, city);

            students.Add(student);
            btnNext.IsEnabled = true;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            posicionInList++;
            if (posicionInList < students.Count)
            {
                Student student = students[posicionInList];
                txtFirstName.Text = student.First_name;
                txtLastName.Text = student.Last_name;
                txtCity.Text = student.City;
                btnPrevious.IsEnabled = true;
            }
            else
            {
                btnNext.IsEnabled = false;
                posicionInList--;
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            posicionInList--;
            if (posicionInList >= 0)
            {
                Student student = students[posicionInList];
                txtFirstName.Text = student.First_name;
                txtLastName.Text = student.Last_name;
                txtCity.Text = student.City;
                btnNext.IsEnabled = true;
            }
            else
            {
                btnPrevious.IsEnabled = false;
                posicionInList++;
            }
        }
    }
}
