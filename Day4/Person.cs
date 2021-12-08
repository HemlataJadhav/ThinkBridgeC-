using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    
    
        public class AgeException:Exception
    {
        public AgeException(string msg):base(msg)
        {

        }
    }
    public class Person
    {
        public int AcceptAge(int age)
        {
            if(age<18)
            {
                throw new AgeException("you are not valid");
            }
            return age;
        }

    }
    
 }
