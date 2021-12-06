using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Method_Overloading
    {

        // add two int 
        public void Addition(int a, int b)
        {
            Console.WriteLine("Addition of Two integers:" + a + b);

        }

        //add three integers
        public void Addition(int a, int b, int c)
        {
            Console.WriteLine("Addition of three integers:" + a + b + c);
        }

        public void Addition(double a, double b)
        {
            Console.WriteLine("Addition of Two double values:" + a + b);
        }
        public void Addition(int a, double b)
        {
            Console.WriteLine("Addition of Integer and double::"+a+b);
        }
            
    }
}
