//Сумма чисел от 1 до n

//1.Напишите программу, которая запрашивает у пользователя целое 
//число и выводит на экран его факториал. Факториал числа n это 
//произведение всех целых чисел от 1 до n. Например, факториал числа 5 равен 1 * 2 * 3 * 4 * 5 = 120. 

//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int S = 1;
//for (int i = 1; i <= n; i++) S *= i;
//Console.WriteLine(S);

//2.Напишите программу, которая запрашивает у пользователя два целых числа a и b и выводит на экран все числа от a до b включительно,которые делятся на 3 или на 5 без остатка. 
//int a,b;
//do
//{
//    Console.Write("Введите нижнюю границу:");
//    a = int.Parse(Console.ReadLine());
//    Console.Write("Введите верхнюю границу:");
//    b = int.Parse(Console.ReadLine());
//}
//while (a >= b);
//for (int i = a; i <= b; i++)
//    if (i % 3 == 0 || i % 5 == 0) Console.Write(i+" ");

//3.Напишите программу, которая запрашивает у пользователя целое 
//число n и выводит на экран первые n чисел Фибоначчи. 
//Последовательность Фибоначчи начинается с чисел 0 и 1, а каждое
//следующее число равно сумме двух предыдущих чисел. 
//Например, первые 10 чисел Фибоначчи это: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.

//using System.Threading.Channels;

//int n;
//do
//{
//    Console.Write("Введите число больше нуля:");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int pred = 0;
//Console.Write(pred+" ");
//int current = 1;
//for (int i = 1; i < n; i++)
//{
//    Console.Write(current+" ");
//    int temp = pred;
//    pred = current;
//    current = pred+temp;
//}

//Напишите программу, которая запрашивает у пользователя строку -
//слово и выводит его в обратном порядке.
//Console.Write("Введите строку:");
//string str=Console.ReadLine();
//for(int i=str.Length-1; i>=0; i--) Console.Write(str[i]);

//Напишите программу, где от пользователя берется на ввод строка 
//слово и производится проверка - является ли слово палиндромом или нет. С выводом пользователю результата 
//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//string reverse = "";
//for(int i=str.Length-1; i>=0; i--) reverse += str[i];
//if (str==reverse) Console.WriteLine("Полиндром");
//else Console.WriteLine("Не полиндром");

//Напишите программу, которая запрашивает у пользователя строку и
//выводит каждый второй символ этой строки. 
//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//for (int i = 1;i<str.Length;i+=2)
//    Console.Write(str[i]);

//Напишите программу, которая запрашивает у пользователя строку  
//выводит ее на экран, заменяя каждую гласную букву на символ "*". 
//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//for (int i = 0; i < str.Length; i++)
//{
//    if (str[i] == 'а' || str[i] == 'е' || str[i] == 'ё' ||
//        str[i] == 'и' || str[i] == 'о' || str[i] == 'э' ||
//        str[i] == 'ю' || str[i] == 'я' || str[i] == 'у' ||
//        str[i] == 'ы')
//    {
//        str = str.Remove(i,1);
//        str = str.Insert(i, "*");
//    }
//}
//Console.WriteLine(str);

//1.Написать программу, которая выводит на экран таблицу умножения 
//от 1 до 10, используя вложенный цикл for. 

//for (int i = 1; i <=10 ; i++)
//{
//	for (int j = 1; j <= 10; j++)
//	{
//		Console.Write($"{i}*{j}={i * j} ");
//	}
//	Console.WriteLine();
//}

//for (int i = 5; i >= 1; i--)
//{
//	for (int j = 1; j <= i; j++)
//	{
//		Console.Write("*");
//	}
//	Console.WriteLine();
//}
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j <9; j++)
    {
        //if(i==1&&j==5) Console.Write("*");
        //else if(i==2&&j>3&&j<7) Console.Write("*");
        //else if(i==3&&j>2&&j<8) Console.Write("*");
        //else if (i == 4 && j > 1 && j < 9) Console.Write("*");
        //else if(i==5) Console.Write("*");
        //else if (i == 6 && j > 1 && j < 9) Console.Write("*");
        //else if (i == 7 && j > 2 && j < 8) Console.Write("*");
        //else if (i == 8 && j > 3 && j < 7) Console.Write("*");
        //else if (i == 9 && j == 5) Console.Write("*");
        //else Console.Write(" ");
        if (j< i % 2)
        {
            for (int k = 1; k < i % 2; k += 2) Console.Write("*");
            
        }
        else if(j>i%2)
        {
            for (int k = i % 2; k >0; k += 2) Console.Write("*");
        }
        else Console.Write(" ");
    }
    Console.WriteLine();
}