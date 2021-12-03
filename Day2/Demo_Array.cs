using System;

namespace Day2
{
    public static class Demo_Array
    {
        public static void demo_Array()
        {
            Console.WriteLine("*************Implementing array in c#**************");
            Console.WriteLine();
             string[] fruits = { "Apple", "Banana", "PineApple", "Watermelon" };
            Console.WriteLine( fruits[1]);
            fruits[1] = "grapes";
            for(int i=0;i<fruits.Length;i++)
            {
                Console.WriteLine(fruits[i]);
            }
            foreach(var a in fruits)
            {
                Console.WriteLine(a);
            }
        }
    }
}
