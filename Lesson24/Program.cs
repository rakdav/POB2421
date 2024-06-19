//long Fact(int n)
//{
//    long f = 1;
//    for (int i = 1; i <= n; i++) f *= i;
//    return f;
//}
//long FactRec(int n)
//{ 
//    if (n == 0) return 1;
//    else return n * FactRec(n-1);
//}
//long Ege1(int n)
//{
//    if (n == 1) return 1;
//    else if (n == 2) return 3;
//    else return Ege1(n - 1) * n + Ege1(n - 2) * (n - 1);
//}
//long Ege2(int n)
//{
//    if (n <= 1) return 0;
//    else if (n > 1 && n % 2 != 0) return Ege2(n - 1) + 3 * n * n;
//    else return n / 2 + Ege2(n - 1) + 2;
//}
//Console.Write("Введите n:");
//int n;
//int.TryParse(Console.ReadLine(), out n);
//Console.WriteLine($"Факториал {n} равен {Fact(n)}");
//Console.WriteLine($"Факториал {n} равен {FactRec(n)}");*/
////Console.WriteLine($"Егэ1 {n} равен {Ege1(n)}");
//Console.WriteLine($"Егэ2 {n} равен {Ege2(n)}");

using System;

/// <summary>
///  Вычисляет высоту пирамиды i для системы башен p
/// </summary>
/// <param name="p">Ханойские башни</param>
/// <param name="i">Пирамида для котроой вычисляется высота</param>
/// <returns>Высоту приамиды i</returns>
int c = 0; 
int Height(int[,] p, int i)
{
    int N = p.GetLength(1);
    int j = N;
    for (; j > 0; j--)
        if (p[i, j - 1] > 0) return j;
    return 0;
}
/// <summary>
///  Перемещает 1 диск с пирамиды i на пирамиду j для системы башен p
/// </summary>
/// <param name="p">Ханойские башни</param>
/// <param name="i">Исходная пирамида</param>
/// <param name="j">Пирамида назначения</param>
void Move1(int[,] p, int i, int j)
{
    int hi = Height(p, i);
    int hj = Height(p, j);
    p[j, hj] = p[i, hi - 1];
    p[i, hi - 1] = 0;
    c++;
    for (int k = 0; k < p.GetLength(0); k++)
    {
        for (int m = 0; m < p.GetLength(1); m++)
        {
            Console.Write(p[k, m] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Move(int[,] p, int i, int j, int M)
{
    if (M == 1) Move1(p, i, j);
    else
    {
        Move(p, i, 3 - i - j, M - 1);
        Move1(p, i, j);
        Move(p, 3 - i - j, j, M - 1);
    }
}

int N = 3; 		//Высота пирамид
int[,] p = new int[3, N];
for (int i = 0; i < N; i++) p[0, i] = 2*(N-i)+1;
//for (int i = 0; i < p.GetLength(0); i++)
//{
//    for(int j = 0; j < p.GetLength(1); j++)
//    {
//        Console.Write(p[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Move(p,0, 2, 3);
//Console.WriteLine(c);
void NumberOut(int n)
{
    if (n == -1) return;
    else NumberOut(n - 1);
    Console.Write(n + " ");
}

//NumberOut(3);
//Console.WriteLine((int)'а');//1072
//Console.WriteLine((int)'я');//1103
void Alfabet(int n)
{
    if (n == 1071) return;
    else Alfabet(n - 1);
    Console.Write((char)n + " ");
}
//Alfabet(1103);
void PrintV(int a, int b)
{
    if (a == b) Console.Write(a + " ");
    else if (a < b)
    {
        PrintV(a, b - 1);
        Console.Write(b + " ");
    }
    else if (a > b)
    {
        Console.Write(a + " ");
        PrintV(a - 1, b);
    }
}
//PrintV(5, 9);
//Console.WriteLine();
//PrintV(9, 5);

int sum(int n)
{
    if (n>0&&n<10) return n;
    else return n % 10 + sum(n / 10);
}

Console.WriteLine(sum(128));
