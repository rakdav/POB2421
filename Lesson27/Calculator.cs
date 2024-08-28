using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27
{
    internal class Calculator
    {
        public double Add(double x,double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mult(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if(y!=0) return x / y;
            throw new DivideByZeroException("Делить на 0 нельзя");
        }
    }
}
