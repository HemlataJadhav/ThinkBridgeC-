using System;

namespace Day2
{
    
   public static  class As_Operator
    {
       public static void as_Operator()
        {
            Console.WriteLine("As operator Demo");
            object[] MyObject = new object[4];
            MyObject[0] = "string";
            MyObject[1] = 101;
            MyObject[2] = null;
            MyObject[3] = new ClassA();

            for(int i=0;i<MyObject.Length;i++)
            {
                string s = MyObject[i] as String; //will check whether it is compatible with string or not
                Console.Write("{0}:",i);

                if(s!=null)
                {
                    Console.WriteLine("'"+s+"'");
                }
                else
                {
                    Console.WriteLine("not a string...!");
                }
               
            }
            Console.ReadKey();
        }
    }
    internal class ClassA
    {

    }
}
