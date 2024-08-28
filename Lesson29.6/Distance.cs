using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29._6
{
    internal class Distance
    {
        private double mm;
        public Distance(double mm)=>this.mm = mm;
        public double toSm() => this.mm / 10;
        public double toMetr() => this.mm / 1000;
        public double toKm() => this.mm / 1E+6;
        public double toDm() => this.mm / 100;
    }
}
