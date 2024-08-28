//int s = 0;
//Console.Write("Введите 1 число:");
//int a = int.Parse(Console.ReadLine());
//s += a;
//Console.Write("Введите 2 число:");
//a = int.Parse(Console.ReadLine());
//s += a;
//Console.Write("Введите 3 число:");
//a = int.Parse(Console.ReadLine());
//s += a;
//Console.Write("Введите 4 число:");
//a = int.Parse(Console.ReadLine());
//s += a;
//Console.Write("Введите 5 число:");
//a = int.Parse(Console.ReadLine());
//s += a;
//Console.WriteLine(s);

//int s = 0;
//int i = 1;//счетчик чисел
//while (i<=5)
//{
//    Console.Write($"Введите {i} число:");
//    int a=int.Parse( Console.ReadLine());
//    s += a;
//    i++;
//}
//Console.WriteLine(s);

//int s = 0;
//int i = 1;//счетчик чисел
//do
//{
//    Console.Write($"Введите {i} число:");
//    int a = int.Parse(Console.ReadLine());
//    s += a;
//    i++;
//}
//while (i <= 5);
//Console.WriteLine(s);

//Ввести число больше нуля
//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n=int.Parse(Console.ReadLine());
//}
//while (n<=0);

//1.Напишите программу, которая запрашивает у пользователя целое 
//число и выводит на экран все числа от 1 до этого числа включительно. 
//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 1;
//while (i <= n)
//{
//    Console.Write(i++ + " ");
//  //  i++;
//}

//2.Напишите программу, которая запрашивает у пользователя два целых 
//числа и выводит на экран все числа между этими двумя числами 
//(включая их), увеличивая каждое число на 1. 
//int n, m;
//do
//{
//    Console.Write("Введите первое число:");
//    n=int.Parse(Console.ReadLine());
//    Console.Write("Введите второе число:");
//    m = int.Parse(Console.ReadLine());
//    if (m <= n) Console.WriteLine("Первое число должно быть меньше второго");
//}
//while (m<=n);
//int i = n;
//while (i <= m)
//{
//    Console.Write(i++ + " ");
//}

//3.Напишите программу, которая запрашивает у пользователя целое 
//число и выводит на экран все нечетные числа от 1 до этого числа 
//включительно. 

//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 1;
//while (i <= n)
//{
//    Console.Write(i + " ");
//    i += 2;
//}
//4.Напишите программу, которая запрашивает у пользователя целое 
//число и выводит на экран таблицу умножения для этого числа от 1 до 10
//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 1;
//while (i <= 10)
//{
//    Console.WriteLine($"{i}*{n}={i++*n}");
//}

//5.Напишите программу, которая запрашивает у пользователя целое 
//число и выводит на экран сумму всех чисел от 1 до этого числа 
//включительно. 

//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int s = 0;
//int i = 1;
//while (i <= n)
//{
//    s += i++;
//}
//Console.WriteLine(s);

//6.Напишите программу, которая запрашивает у пользователя целое 
//число и выводит на экран все его делители.
//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 1;
//while (i <= n)
//{
//    if (n % i == 0) Console.Write(i+" ");
//    i++;
//}

//7.Напишите программу, которая запрашивает у пользователя целое 
//число и проверяет, является ли это число простым. 
//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 2;
//int k = 0;//количество делителей
//while (i < n)
//{
//    if (n % i++ == 0)
//    {
//        k++;
//        break;
//    }
//}
//if (k == 0) Console.Write("Число простое");
//else Console.WriteLine("Число не простое");

//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 0;
//while (++i <=n)
//{
//    if (i % 2 == 0) continue; 
//    Console.WriteLine(i);
//}

//8.Напишите программу, которая запрашивает у пользователя целое 
//число и выводит на экран все простые числа от 1 до этого числа 
//включительно. 

//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 1;
//while (i <= n)
//{
//    int j = 2;
//    int k = 0;
//    while(j < i)
//    {
//        if (i % j == 0)
//        {
//            k++;
//            break;
//        }
//        j++;
//    }
//    if (k == 0) Console.Write(i +" ");
//    i++;
//}
//9. Вывести двоичное представление числа
int n;
do
{
    Console.Write("Введите число больше нуля:");
    n = int.Parse(Console.ReadLine());
}
while (n <= 0);
string result = "";
while (n != 1)
{
    result += n % 2;
    n /= 2;
}
result+="1";
int i = result.Length - 1;
while(i >= 0)
{
    Console.Write(result[i--]);    
}

