using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27._1
{
    internal class Analizer
    {
        private string? stroka;
        public Analizer(string? stroka)
        {
            this.stroka = stroka;
        }
        public string? getStroka()
        {
            return this.stroka;
        }
        public int getLength()
        {
            return stroka!.Length;
        }
        public bool haveSubString(string str) 
        {
            return stroka!.Contains(str);
        }
        public string toUpper()
        {
            return stroka!.ToUpper();
        }
        public string toLower()
        {
            return  stroka!.ToLower();
        }
    }
}
