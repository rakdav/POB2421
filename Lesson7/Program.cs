//Console.Write("Введите x:");
//double x=double.Parse(Console.ReadLine());
//if (x >= 0) Console.WriteLine($"|{x}|={x}");
//else Console.WriteLine($"|{x}|={-x}");
//Console.Write("Введите x:");
//double x=double.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//if (x > y) Console.WriteLine($"{x}>{y}");
//else if (y > x) Console.WriteLine($"{x}<{y}");
//else Console.WriteLine($"{x}={y}");


//bool A = true;
//bool B = false;
//bool C = false;
//Console.WriteLine(A && !B || C);

//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
////Console.WriteLine(x*x+y*y<=4);

//if ((y >= 0.5 && y <= 1.5 && x <= 2) || (x >= 2)) Console.WriteLine("Попал");
//else Console.WriteLine("Не попал");

//Console.Write("Введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Введите c:");
//double c = double.Parse(Console.ReadLine());
//double d = b * b - 4 * a * c;
//if (d > 0)
//{
//    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//    Console.WriteLine($"x1={x1:F2} x2={x2:F2}");
//}
//else if (d == 0)
//{
//    double x = -b / (2 * a);
//    Console.WriteLine($"x={x:F2}");
//}
//else Console.WriteLine("Корней нет");
Console.Write("Введите a:");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите b:");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите c:");
double c = double.Parse(Console.ReadLine());
if (a > b)
{
    if (b > c) Console.WriteLine($"{a},{b},{c}");
    else if (a > c) Console.WriteLine($"{a},{c},{b}");
         else Console.WriteLine($"{c},{a},{b}");
}
else if (a > c) Console.WriteLine($"{b},{a},{c}");
     else if (b > c) Console.WriteLine($"{b},{c},{a}");
           else Console.WriteLine($"{c},{b},{a}");