using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson28._1
{
    internal class ArrayClass
    {
        private double[] mas;
        public ArrayClass(int n)
        {
            this.mas = new double[n];
            Random random = new Random();
            mas = mas.Select(i => i + random.NextDouble()*100).ToArray();
        }
        public double[] getMas() => this.mas;
        public void Print()
        {
            foreach (var item in mas) Console.Write($"{item:F2} ");
            Console.WriteLine();
        }
        public double Sum()=>mas.Sum();
        public double Max()=>mas.Max();
        public double Min()=>mas.Min();
        public void Sort()=>Array.Sort(mas);
    }
}
