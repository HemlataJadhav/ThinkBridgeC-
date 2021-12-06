using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Employee
    {
         static int count;//initial value is 0
        int empid;
        double basicsalary;
        string ename;
        double ta, da, hra, pf;

        public Employee()
        {
            empid = ++count;
            basicsalary = 30000;
            ename = "Arav";

        }
        public Employee( string ename, double basicsalary)
        {
            this.empid = ++count;
            this.ename = ename;
            this.basicsalary = basicsalary;

        }
        public override string ToString()
        {
            return "employee details are as follows:\n" + "Employee name:" + ename + "\n Employee ID is:" + empid + "\n Employee Salary:" + basicsalary + "\n Employee Net Salary : " + NetDeduction();
        }

        public double NetDeduction()
        {
            ta = basicsalary * 25 / 100;
            da = basicsalary * 20 / 100;
            hra = basicsalary * 20 / 100;
            pf = basicsalary * 12 / 100;

            return basicsalary + ta + da + hra - pf;
        }
        //public void Display()
        //{
        //    Console.WriteLine("employee details:");
        //    Console.WriteLine("employee name is" + ename);
        //    Console.WriteLine("employee ID is" + empid);
        //    Console.WriteLine("employee salary is" + basicsalary);
        //}
    }
}
