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
