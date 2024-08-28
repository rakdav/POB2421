namespace Lesson28._2
{
    public class ClassArray
    {
        public static double Sum(double[] mas) => mas.Sum();
        public static double Max(double[] mas) => mas.Max();
        public static double Min(double[] mas) => mas.Min();
        public static void Sort(double[] mas) => Array.Sort(mas);
        public static void Print(double[] mas)
        {
            foreach (var item in mas) Console.Write($"{item:F2} ");
            Console.WriteLine();
        }
    }
}
