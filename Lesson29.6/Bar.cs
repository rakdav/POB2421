using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29._6
{
    internal class Bar
    {
        private double bar;
        public Bar(double bar)
        {
            this.bar = bar;
        }
        public double toMRS() => bar / 133.3;

    }
}
