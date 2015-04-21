using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
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
}
