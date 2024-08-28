using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29._1
{
    internal class NumberGenerator
    {
        private Random random;
        public NumberGenerator()
        {
            this.random = new Random();
        }
        public int GetInteger()
        {
            return random.Next(1,1000);
        }
        public double GetDouble()
        {
            return random.NextDouble() * 1000;
        }
        public bool GetBool()
        {
            if(random.Next(0, 2)==1) return true;
            return false;
        }
        public string GetString()
        {
            string res = "";
            for (int i = 0; i < random.Next(20); i++)
            {
                res += (char)random.Next(65, 123);
            }
            return res;
        }
    }
}
