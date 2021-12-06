using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3  //project .collection of types class,interface,delegate,enum,struct
{
   public  class Date
    {
        //data members
        private int day, year;
        private string month;
        //default or parameterless costructor
        public Date()
        {
            day = 12;           //4 bytes
            year = 2021;        //4 bytes
            month = "dec";

        }
        //parameterized constructor
        public Date(int dd,string mm,int yy)
        {
            day = dd;
            month = mm;
            year = yy;
        }

        //method to init values to the member

        //public void SetData()
        //{
        //    day = 12;           //4 bytes
        //    year = 2021;        //4 bytes
        //    month = "dec";         //3 bytes
        //}
        //method for returning data
        //public string getdata()
        //{
        //    return "date is:" + day + "/" + month + "/" + year;
        //}
        //string representation of object
        public override string ToString()
        {
            return "Date is:" + day + "/" + month + "/" + year;
        }

    }
}
