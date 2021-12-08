using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Hashtable_Demo
    {
       public Hashtable Add_Elements(Hashtable hashtable)
        {
            hashtable.Add(1, "apple");
            hashtable.Add(2, "Banana");
            hashtable.Add(3, "pineapple");
            hashtable.Add(4, "watermelon");

            return hashtable;
        }
    }
}
