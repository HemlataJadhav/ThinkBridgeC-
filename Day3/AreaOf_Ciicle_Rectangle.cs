using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class AreaOf_Ciicle_Rectangle
    {
        double radious, len, br;

        public AreaOf_Ciicle_Rectangle(double radious,double len,double br)
        {
            this.radious = radious;
            this.len = len;
            this.br = br;
        }
        public double AreaOfCircle()
        {
            double areaofcircle = 3.14 * radious * radious;
            return areaofcircle;
        }
        public double AreaOfRectangle()
        {
            double areaofrectangle = len*br;
            return areaofrectangle;
        }

        public override string ToString()
        {
            return "area of circle is:"+ AreaOfCircle()+"\n area of rectangle is :"+ AreaOfRectangle();
        }

    }
}
