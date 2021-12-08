using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Calculate
    {
        public static void Calculations(ref int a, out int square, out int cube)
        {
            cube = a * a * a;
            square = a * a;
        }

       
    }
}
