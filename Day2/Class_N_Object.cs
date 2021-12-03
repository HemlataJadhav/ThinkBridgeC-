using System;

namespace Day2
{
    public static class Class_N_Object
    {
        
        public static void class_N_Object()
        {
            Console.WriteLine("Class and object Demo");

            //Program obj = new Program();
            //obj.name = "Raj";
            //Console.WriteLine(obj.name);

            //Program pobj = obj;
            //Console.WriteLine(pobj.name);


            string fname = "hema";
            string lname = "jadhav";
            string fullname = fname + lname;
            Console.WriteLine("full name is :"+fullname);
            Console.WriteLine(fullname.ToLower());
            Console.WriteLine(string.Concat(fname,lname));
            Console.WriteLine("length:"+fullname.Length);
            Console.WriteLine($"{fname} is my first name and {lname} is my last name");
            Console.WriteLine(fullname[0]);
            Console.WriteLine(fullname.IndexOf("a"));
            Console.WriteLine();
        }
    }
}
