using System;

namespace Day2
{
    public static class String_Format
    {
       public static void string_Format()
        {
            Console.WriteLine("String Formatting...");
            decimal price = 19.36m;
            string s = string.Format("The current proces is {0} per ounce",price);
            string datestring = string.Format("it is now{0:d} at {0:t}", DateTime.Now);
            Console.WriteLine(datestring);  
            Console.WriteLine(s);




            //s += String.Format("{0,-10} {1,-10:N0}\n", years[index], population[index]);
        }
    }
}
