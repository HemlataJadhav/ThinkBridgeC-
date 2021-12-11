using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]

    class ProjectAttribute:Attribute
    {
        public  string version { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return "version"+version+"Name:"+Name;
        }
    }
}
