using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{

    public class NameException : Exception
    {
        public NameException(string name):base( name)
        {

        }
    }
    class Person1
    {
        public string AcceptName(string name)
        {
            if (name=="")
            {
                throw new NameException("name is empty");
            }
            return name;
        }

    }
}
