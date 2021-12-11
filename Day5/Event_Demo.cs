using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDemo;

namespace Day5
{
    class Event_Demo
    {

        
        public event  DisplayMsg IsValid;   //access specifier /event/delegate name/event name
       
        public delegate void DisplayMsg();

        public static void ErrorMsg()
        {
            Console.WriteLine("user not valid");
        }

        public  int AcceptAge(int age)
        {
            if(age<18)
            {
                IsValid();
            }
            return age;
        }

    }
}
