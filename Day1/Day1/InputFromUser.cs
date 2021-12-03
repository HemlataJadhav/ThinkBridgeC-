using System;

namespace Day1
{
    public static class InputFromUser
    {
        public static void inputFromUser()
        {
            Console.WriteLine("Demo taking input from user");
            Console.WriteLine("enter your name::");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("my name is:"+name+"  and age is:"+age);
            if(age>=18)
            {
                Console.WriteLine("you are aligible to vote");
            }
            else
            {
                Console.WriteLine("your age is less that 18.So you are not eligible for voting");
            }


        }
    }
}
