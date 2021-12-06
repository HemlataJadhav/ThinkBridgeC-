using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Student
    {

        private int rollno;
         private string name,class_of_student;

        public void SetData()
        {
            rollno = 12;
            name = "raj";
            class_of_student = "BE";
        }
        public string  GetData()
        {
            return "student info:\n" + "roll no is:"+rollno + "\n name is:" + name + "\nclass of student:" + class_of_student;
        }
    }
}
