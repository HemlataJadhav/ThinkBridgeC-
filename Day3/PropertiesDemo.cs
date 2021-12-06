using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class PropertiesDemo
    {
        private int rollno;
        private string student_name;

        //public int Rollno

        //{
        //    get
        //    {
        //        return rollno;
        //    }
        //    set
        //    {
        //        rollno = value;
        //    }
        //}

        //public string Student_name
        //{
        //    get
        //    {
        //        return student_name;
        //    }
        //    set
        //    {
        //        student_name = value;
        //    }
        //}

        //auto implemented property


        public string  Student_name { get; set; }
        public int Rollno { get; set; }
        public override string ToString()
        {
            return "details:\nname:"+ Student_name + "\n roll no:"+Rollno;
        }
    }
}
