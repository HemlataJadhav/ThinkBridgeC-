using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Product_Manager:Employee
    {

        double fa, ma;
        public Product_Manager():base()
        {
            fa = 3542;
            ma = 3562;
        }
        public Product_Manager(string empname, double basicsalary, double fa, double ma) : base(empname, basicsalary)
        {
            this.ma = ma;
            this.fa = fa;
            
        }
        public override double NetDeduction()
        {
            netpaid = basicsalary + ma + fa;
            return netpaid;

        }
        public override string ToString()
        {
            return "netpaid salary is :" + netpaid;
        }
    }
}
