using System;

namespace Day1
{
    public static class DataTypes
    {
        public static void dataTypes()
        {
            Console.WriteLine("**************Data types in c# are as follows***************");
            Console.WriteLine();
            string messege = "I am feeling lucky";
            int age = 20; //4 bytes, long int takes 8 bytes
            double avgSalary = 127364.3097D;
            char choice = 'A';
            bool condition = true;
            float Number = 1.2F;
          
            Console.WriteLine("messege  type is :"+messege.GetType());
            Console.WriteLine("age type is :"+age.GetType());
            Console.WriteLine("avgSalary type is :"+ avgSalary.GetType());
            Console.WriteLine("choice  type is :"+ choice.GetType());
            Console.WriteLine("condition  type is :"+condition.GetType());
            Console.WriteLine("number type is :"+ Number.GetType());
;

        }
    }
}
