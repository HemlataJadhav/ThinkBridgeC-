using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{

    
    class Auto_Implemented_Property
    {
        private double totalper;

       
        public int englishmarks { get; set; }
        public int sciencemarks { get; set; }
        public int mathmarks { get; set; }

        public double TotalMarks()
        {
             totalper = englishmarks + sciencemarks + mathmarks;
            return totalper;


        }
        public double Percentage()
        {
            double percentage = totalper / 300 * 100;
            return percentage;
        }

        public override string ToString()
        {
            return "total marks:" + TotalMarks() + "\n percentage:" + Percentage();
        }
    }  
}
