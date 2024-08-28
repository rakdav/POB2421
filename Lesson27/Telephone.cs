using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27
{
    internal class Telephone
    {
        private int daySay;
        private double timeSay;
        private double coastSay;
        public Telephone(int daySay, double timeSay, double coastSay)
        {
            this.daySay = daySay;
            this.timeSay = timeSay;
            this.coastSay = coastSay;
        }
        public Telephone()
        {
        }
        public int getDaySay()
        {
            return daySay;
        }
        public double getTimeSay()
        {
            return timeSay; 
        }
        public double getCoastSay()
        {
            return coastSay;
        }
        public void setDaySay(int daySay)
        {
            this.daySay = daySay;
        }
        public void setTimeSay(double time)
        {
            this.timeSay= time;
        }
        public void setCoastSay(double coast)
        {
            this.coastSay= coast;
        }
        public double getTotal()
        {
            if(daySay>=1&&daySay<=5) return timeSay*coastSay;
            return 0.9* timeSay * coastSay;
        }

    }
}
