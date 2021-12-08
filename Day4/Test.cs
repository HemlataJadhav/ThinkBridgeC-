using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Test
    {
        public class Test1<T>
        {
            private T data;
            public Test1(T data)
            {
                this.data = data;
            }
            public T Print()
            {
                return data;
            }
        }
    }
}
