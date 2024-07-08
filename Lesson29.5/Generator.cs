using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29._5
{
    internal class Generator
    {
        public int GenNumber(int low, int high)
        {
            Random random = new Random();
            return random.Next(low, high + 1);
        }
    }
}
