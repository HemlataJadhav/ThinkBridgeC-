using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDemo;

namespace Day5
{
    public class Delegates_Demo
    {
        public delegate int MyDelegate(int n1, int n2); //access specifier,delegate keyword return type /name of delegate (argu,ent list)

        
        public  int  Addition(int a,int b)
        {
            return a + b;
        }
        public int sub(int a,int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
    }
}
