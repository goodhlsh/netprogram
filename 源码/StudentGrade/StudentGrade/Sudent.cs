using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentGrade
{
    public class Sudent
    {
        private string stuid;
        private string name;
        private string gender;
        private string c;

        public string Stuid
        {
            get
            {
                return stuid;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
        }

        public string Cl
        {
            get
            {
                return c;
            }
        }
        public Sudent(string id,string name,string gender,string cl)
        {
            this.stuid = id;
            this.name = name;
            this.gender = gender;
            this.c = cl;
        }
    }
}
