using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    /// <summary>
    /// Program of a University
    /// </summary>
    public class UProgram
    {
        private string name;
        private string university;
        private Degree degree;

        public UProgram(string name, string university, Degree degree=null)
        {
            this.name = name;
            this.university = university;
            this.degree = degree;
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

        public Degree Degree
        {
            get { return degree; }
            set { degree = value; }
        }

    }
}
