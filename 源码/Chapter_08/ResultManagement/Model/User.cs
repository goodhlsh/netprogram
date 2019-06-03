using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    { 
        string id;
        string name;
        string pass;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
    }
}
