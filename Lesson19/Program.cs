//Console.Write("Введите первое число:");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Введите второе число:");
//int m = int.Parse(Console.ReadLine());
//Console.Write("Введите операцию:");
//char ch = char.Parse(Console.ReadLine());
//switch (ch)
//{
//    case '+': Console.WriteLine(Add(n,m));break;
//    case '-': Console.WriteLine(Sub(n, m)); break;
//    case '*': Console.WriteLine(Mult(n, m)); break;
//    case '/': Console.WriteLine(Div(n, m)); break;
//}
//int Add(int a, int b)
//{
//    return a + b;
//}
//int Sub(int a,int b)
//{
//    return a - b;
//}
//int Mult(int a, int b)
//{
//    return a * b;
//}
//int Div(int a, int b)
//{
//    if(b!=0) return a/b;
//    throw new Exception("Деление на ноль запрещено");
//}

//Задание 2: Создайте функцию, которая принимает массив целых чисел и возвращает среднее значение. Напишите программу, которая использует
//эту функцию для вычисления среднего значения массива, заполненного пользователем.
//Random random = new Random();
//int[] mas = new int[random.Next(5,11)];
//for (int i = 0; i < mas.Length; i++)
//{
//	mas[i] = random.Next(10, 100);
//	Console.Write(mas[i]+" ");
//}
//Console.WriteLine($"Среднее арифметическое:{Avg(mas):F2}");
//double Avg(int[] mas)
//{
//    double s = 0;
//	for (int i = 0; i < mas.Length; i++) s += mas[i];
//	return s / mas.Length;
//}

//Задание 3: Создайте функцию, которая принимает строку и возвращает ее в обратном порядке. Напишите программу, которая использует эту функцию для переворачивания введенной пользователем строки и выводит результат на экран.
//Console.Write("Введите строку:");
//string myStr = Console.ReadLine();
//Console.WriteLine(Reverse(myStr));
//string Reverse(string str)
//{
//    string res = "";
//    for (int i = str.Length - 1; i >= 0; i--) res += str[i];
//    return res;
//}

//Задание 4: Создайте функцию, которая принимает целое число и возвращает true, если число является простым, и false в противном случае.
//Напишите программу, которая использует эту функцию для проверки простоты числа, введенного пользователем
//Console.Write("Введите число:");
//int n = int.Parse(Console.ReadLine());
//if (IsSimple(n)) Console.WriteLine("Простое");
//else Console.WriteLine("Не простое");
//bool IsSimple(int x)
//{
//    int k = 0;
//	for (int i = 2; i < x; i++)
//	{
//		if (x % i == 0) k++;
//	}
//	if (k == 0) return true;
//	return false;
//}

//Задание 5:Создайте функцию, которая принимает две строки и
//возвращает true, если они являются анаграммами (т.е. содержат одни и те же символы в разном порядке), и false в противном случае. Напишите программу, которая использует эту функцию для проверки анаграммы двух строк, введенных пользователем
//bool IsAnagram(string str1, string str2)
//{
//    if (str1.Length != str2.Length) return false;
//    int k = 0;
//    for (int i = 0; i < str2.Length; i++)
//    {
//        if (str1.Contains(str2[i])) k++;
//    }
//    if (k == str2.Length) return true;
//    return false;
//}
//Console.Write("Введите первое слово:");
//string first = Console.ReadLine();
//Console.Write("Введите второе слово:");
//string second = Console.ReadLine();
//if (IsAnagram(first, second)) Console.WriteLine("Анаграммы");
//else Console.WriteLine("Не анаграммы");

//Задание 1: Создайте функцию, которая принимает строку и возвращает количество слов в этой строке. Напишите программу, которая использует эту функцию для подсчета количества слов во введенном пользователем предложении.
//int StrLength(string str)
//{
//    return str.Split(' ').Length;
//}
//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//Console.WriteLine("Количество слов в строке:"+StrLength(str));

//Задание 2: Создайте функцию, которая принимает целое число и
//возвращает его факториал (произведение всех чисел от 1 до этого числа). Напишите программу, которая использует эту функцию для вычисления факториала числа, введенного пользователем.
//long Factorial(int n)
//{
//	long f = 1;
//	for (int i = 1; i <= n; i++) f *= i;
//	return f;
//}
//Console.Write("Введите число:");
//int n = int.Parse(Console.ReadLine());
//long Fact = Factorial(n);
//Console.WriteLine($"{n}!={Fact}");

//Задание 3: Создайте функцию, которая принимает двумерный массив
//целых чисел и выводит на экран его элементы в виде матрицы. Напишите
//программу, которая использует эту функцию для вывода элементов
//двумерного массива, заполненного пользователем.
//void PrintMatrix(int[,] mas)
//{
//	for (int i = 0; i < mas.GetLength(0); i++)
//	{
//		for (int j = 0; j < mas.GetLength(1); j++)
//		{
//			Console.Write(mas[i,j]+" ");
//		}
//		Console.WriteLine();
//	}
//}
//Random random = new Random();
//int[,] array = new int[random.Next(10), random.Next(10)];
//for (int i = 0; i < array.GetLength(0); i++)
//{
//	for (int j = 0; j < array.GetLength(1); j++)
//	{
//		array[i, j] = random.Next(10, 100);
//	}
//}
//PrintMatrix(array);
//Console.WriteLine();
//array[1, 1] = 8;
//PrintMatrix(array);

//Задание 4: Создайте функцию, которая принимает массив строк и
//возвращает новый массив, содержащий только уникальные элементы.
//Напишите программу, которая использует эту функцию для удаления
//дубликатов из списка строк, заполненного пользователем.
//string[] UniStr(string[] mas)
//{
//	string[] temp=new string[mas.Length];
//	int j = 0;
//	for (int i = 0; i < mas.Length; i++)
//	{
//		if (!temp.Contains(mas[i])) temp[j++] = mas[i];
//	}
//	int k = 0;
//	foreach(string i in mas) if (i.Length != 0) k++;
//	string[] res = new string[k];
//	Array.Copy(temp, res, k);
//	return res;
//}
//Console.WriteLine("Введите элементы 1-го массива:");
//string str = Console.ReadLine();
//string[] masStr = str.Split(' ', ',');
//foreach(string i in UniStr(masStr))
//{
//	Console.Write(i+" ");
//}
//Console.WriteLine();

//Задание 5: Создайте функцию, которая принимает длину сторон
//треугольника и возвращает его площадь. Напишите программу,которая
//использует эту функцию для вычисления площади треугольника с
//заданными сторонами, введенными пользователем
double Area(double a,double b,double c)
{
    double pp = (a + b + c) / 2;
    return Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
}
Console.Write("Введите сторону a:");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите сторону b:");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите сторону c:");
double c = double.Parse(Console.ReadLine());
Console.WriteLine($"Площадь:{Area(a,b,c):F2}");

