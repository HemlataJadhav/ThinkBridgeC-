using System;


namespace Day1
{
   public static class Date_Time
    {
       public static void dateTime()
        {
            Console.WriteLine("Date And time in C#");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.DaysInMonth(2022,2));
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now.TimeOfDay);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i+"-----"+DateTime.Now.TimeOfDay.ToString());
                //System.Threading.Thread.Sleep(3000);

                //Program to display expiry of product after 3 days
            }
            DateTime today = new DateTime(2021, 12, 2);
            Console.WriteLine("Today is " + today.ToString("dddd  MMM dd") + ".");
            //Console.WriteLine(DateTime.Now.TimeOfDay.ToString("MM/dd/yyyy"));
        }
    }
}
