using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public abstract class Absract_Demo
    {
        protected int radious;
        protected double result;
        public abstract double CalculateArea();

        
    }

    public class Circle : Absract_Demo,IPrintable
    {
        public Circle(int radious)
        {
            this.radious = radious;
        }

        public override double CalculateArea()
        {
            result = 3.14 * radious * radious;
            return result;

        }
        public override string ToString()
        {
            return "area of circle is :" + CalculateArea();
        }
        public void PrintableDtails()
        {
            Console.WriteLine("area of circle interface method:"+ CalculateArea());
        }
    }

    public class Rectangle : Absract_Demo
    {
        int width ,height;
        public Rectangle(int width,int height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            result = height*width;
            return result;

        }
        public override string ToString()
        {
            return "area of Rectangle is :" + CalculateArea();
        }
    }
}
