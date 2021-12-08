using System;
using ClassLibraryDemo;

namespace Day5
{
    class Program
    {
       
        static void Main(string[] args)
        {

            int num1 = 5, square,cube;
            Calculate.Calculations(ref num1,out square,out cube);
            Console.WriteLine("square:"+square);
            Console.WriteLine("cube:"+cube);
            Console.ReadKey();
        }

       
    }
}
