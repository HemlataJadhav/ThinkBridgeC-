using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Day1
{
    public static class CultureDateTime
    {
        public static void cultureDateTime()
        {
            Calendar calenderobj = new GregorianCalendar();
            DateTime dt1 = new DateTime(2021, 12, 02, calenderobj);
            Console.WriteLine("year according to gregorian:" + dt1.Year);
            Console.WriteLine("moth acording to gregorian:" + dt1.Month);
            Console.WriteLine("final date according to gregoroian:" + dt1.ToString("d"));
            Console.WriteLine("**********************************************************");

            Calendar japcalenderobj = new JapaneseCalendar();
            DateTime dt2 = new DateTime(2021, 12, 02, japcalenderobj);
            Console.WriteLine("year according to japanese calender:" + dt2.Year);
            Console.WriteLine("moth acording to japanese calender:" + dt2.Month);
            Console.WriteLine("final date according to gjapanese calender:" + dt2.ToString("d"));

           

        }
    }
}
