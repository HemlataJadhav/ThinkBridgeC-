using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Inheritance_Demo:Employee
    {
        private double comm;
         public Inheritance_Demo():base() //invoke base class constructor
        {
            comm = 0.0;
        }

        public Inheritance_Demo(string empname,double basicsalary,double comm):base(empname,basicsalary)
        {
            this.comm = comm;
        }
        public void CalculateSalary()
        {
            hra = basicsalary * 0.20;
            netpaid = basicsalary + comm;
        }
        public override string ToString()
        {
            return "netpaid salary is :"+netpaid;
        }
    }
}
