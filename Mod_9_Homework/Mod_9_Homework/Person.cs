﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_HomeworkN
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
}
