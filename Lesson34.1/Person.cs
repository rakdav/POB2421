using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson34._1
{
    internal class Person
    {
        public string? Name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set { if (value > 0) age = value; } 
        }
    }
}
