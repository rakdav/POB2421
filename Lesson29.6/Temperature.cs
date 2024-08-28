using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29._6
{
    internal class Temperature
    {
        private double temp;
        public Temperature(double temp)
        {
            this.temp = temp;
        }
        public double ToKelvin() => this.temp + 273.15;
        public double ToFarengate() => this.temp * 1.8 + 32;
    }
}
