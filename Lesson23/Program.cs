//ref-параметр ссылка
//void Swap(int x, int y)
//{
//    int temp = x;
//    x = y;
//    y = temp;
//}
//void SwapRef(ref int x,ref int y)
//{
//    int temp = x;
//    x = y;
//    y = temp;
//}
//int a = 6, b = 10;
//Console.WriteLine("a="+a+" b="+b);
//Swap(a, b);
//Console.WriteLine("a=" + a + " b=" + b);
//SwapRef(ref a,ref b);
//Console.WriteLine("a=" + a + " b=" + b);


//out-выходной параметр
//try
//{
//    int x = int.Parse(Console.ReadLine()!);
//}
//catch (FormatException e)
//{

//}
//int x;
//if(int.TryParse(Console.ReadLine(), out x))
//    Console.WriteLine(x);
//else Console.WriteLine("Error input");

//void Sum(int x, int y, out int s)
//{
//    s = x + y;
//}

//int s = 0;
//Sum(4, 9, out s);
//Console.WriteLine(s);

//in - входной параметр
//void func(in int x)
//{
//    //x = 10;
//    Console.WriteLine(x+5);
//}
//void Sum(int[] mas)
//{
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] *= 2;
//    }
//}
//Console.Write("Введите число:");
//int x;
//int.TryParse(Console.ReadLine(),out x);
//func(in x);

//int[] m = { 5, 3, 9, 6 };
//Sum(m);
//foreach (int item in m)
//{
//    Console.WriteLine(item+" ");
//}
//Console.WriteLine();

//params - используется для передачи неопределеного количества параметров
//void Sum(params int[] numbers)
//{
//    int result = 0;
//    foreach (int n in numbers) result += n;
//    Console.WriteLine(result);
//}

//Sum(m);
//Sum(1, 34, 2, 6, 9, 4, 6, 3, 3);
//double s;
//void Divide(double a, double b, out double s)
//{
//    s = 0;
//    try
//    {
//        if (b != 0) s = a / b;
//        else throw new DivideByZeroException("Деление на ноль");
//    }
//    catch(DivideByZeroException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//Console.Write("Введите первую переменную:");
//double x;
//double.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите вторую переменную:");
//double y;
//double.TryParse(Console.ReadLine(), out y);
//Divide(x, y,out s);
//Console.WriteLine(s);

//void CalculateAverage(params double[] numbers)
//{
//    double s = 0;
//    foreach (double i in numbers) s += i;
//    Console.WriteLine($"AVG={(s/numbers.Length):F2}");
//}
//CalculateAverage(4, 8, 0, 3, 2);
//CalculateAverage(5, 2);
//int count;
//void ModifyArray(int[] mas, out int count)
//{
//	count=0;
//	for (int i = 0; i < mas.Length; i++)
//	{
//		if (mas[i] != mas[i] * mas[i]) count++;
//		mas[i] *= mas[i];
//	}
//}
//int[] mas = { 6, 4, 3, 9, 1 };
//ModifyArray(mas, out count);
//foreach (int i in mas) Console.Write(i+" ");
//Console.WriteLine();
//Console.WriteLine("Count="+count);
string str = Console.ReadLine()!;








