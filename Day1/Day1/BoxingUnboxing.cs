using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public static class BoxingUnboxing
    {
        public static void boxingUnboxing()
        {
            int i = 10;
            object O = i;
            int j = (int)O;
            Console.WriteLine("value of j is:" + j);
            Console.WriteLine("value of O is:" + O);
        }
    }
}
