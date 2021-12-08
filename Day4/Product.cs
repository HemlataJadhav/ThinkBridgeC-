using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Product
    {
        private int code;
        private string name;
        private double price ;

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            return "Code:"+Code+"\tName:"+Name+"\tPrice:"+price;
        }
    }
}
