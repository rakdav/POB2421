//Random random = new Random();
//int[][] mas = new int[random.Next(5,11)][];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = new int[random.Next(5,16)];
//}
//for (int i = 0; i < mas.Length; i++)
//{
//    for(int j = 0; j < mas[i].Length; j++)
//    {
//        mas[i][j] = random.Next(10,100);
//        Console.Write(mas[i][j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//int[,,] tripleMas = new int[5, 7, 2];
//for (int k = 0; k < tripleMas.GetLength(2); k++)
//{
//    for (int i = 0; i < tripleMas.GetLength(0); i++)
//    {
//        for (int j = 0; j < tripleMas.GetLength(1); j++)
//        {
//            tripleMas[i, j, k] = random.Next(10, 100);
//            Console.Write(tripleMas[i, j, k] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}

//1.Шахматная доска
//Создайте массив массивов, представляющий собой шахматную доску,
//где белые клетки представлены символом "W", а черные - символом "B". 
//Затем напишите программу, которая будет выводить данную доску на 
//экран, чтобы она выглядела как настоящая шахматная доска. 

//char[,] shahMatDesk = new char[8, 8];
//for (int i = 0; i < shahMatDesk.GetLength(0); i++)
//{
//	for (int j = 0; j < shahMatDesk.GetLength(1); j++)
//	{
//		if ((i + j) % 2 == 0) shahMatDesk[i, j] = 'B';
//		else shahMatDesk[i, j] = 'W';
//		Console.Write(shahMatDesk[i,j]+" ");
//	}
//	Console.WriteLine();
//}

//Покер
//Random random = new Random();
//string[] mast = { "Червы", "Буби", "Крести", "Пики" };
//string[] nominal = {"Туз","2", "3", "4", "5", "6", "7",
//					"8", "9", "10", "Валет", "Дама", "Король" };
//int[,,] karts = new int[2, 2, 4];
//for(int k = 0; k < karts.GetLength(2); k++)
//{
//	for(int i = 0; i < karts.GetLength(0); i++)
//	{
//        for (int j = 0; j < karts.GetLength(1); j++)
//		{
//			if (j == 0)
//			{
//				karts[i, j, k] = random.Next(0, 4);
//				Console.Write((i+1)+" "+mast[karts[i, j, k]]+" ");
//			}
//			else
//			{
//				karts[i, j, k] = random.Next(0, 13);
//				Console.Write(nominal[karts[i, j, k]]);
//			}
//        }
//        Console.WriteLine();
//    }
//	Console.WriteLine();
//}

//Создайте трехмерный массив, заполните его случайно [4,6,8]
//Random random = new Random();
//int[,,] mas = new int[4,6,8];
//for (int k = 0; k <mas.GetLength(2); k++)
//{
//    for(int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            mas[i, j, k] = random.Next(10, 100);
//            Console.Write(mas[i,j,k]+" ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
//Console.Write("Введите число для вставки последнего элемента");
//int last = int.Parse(Console.ReadLine());
//mas[mas.GetUpperBound(0), mas.GetUpperBound(1), mas.GetUpperBound(2)] = last;

//Console.Write("Введите число для вставки первого элемента");
//int  first= int.Parse(Console.ReadLine());
//mas[mas.GetLowerBound(0),mas.GetLowerBound(1), mas.GetLowerBound(2)] = first;

//Console.Write("Введите три числа через запятую:");
//string strNumbers = Console.ReadLine();
//string[] numbers = strNumbers.Split(",");
//Console.Write("Введите число для вставки:");
//int num = int.Parse(Console.ReadLine());
//mas[int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2])] = num;
//Console.WriteLine("Вставка");
//for (int k = 0; k < mas.GetLength(2); k++)
//{
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            Console.Write(mas[i, j, k] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}


//mas[mas.GetUpperBound(0), mas.GetUpperBound(1), mas.GetUpperBound(2)] = 0;
//mas[mas.GetLowerBound(0), mas.GetLowerBound(1), mas.GetLowerBound(2)] = 0;
//Console.Write("Введите три числа через запятую:");
//strNumbers = Console.ReadLine();
//numbers = strNumbers.Split(",");
//mas[int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2])] = 0;
//Console.WriteLine("Удаление");
//for (int k = 0; k < mas.GetLength(2); k++)
//{
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            Console.Write(mas[i, j, k] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}

//using System.Security.Claims;

//int[] mas1 = new int[3];
//int[] mas2 = new int[3];
//Random random = new Random();
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.Next(10);
//    Console.Write(mas1[i]+" ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.Length; i++)
//{
//    mas2[i] = random.Next(10);
//    Console.Write(mas2[i]+" ");
//}
//Console.WriteLine();
//Console.WriteLine();
//int[,] mas3 = new int[2, 3];
//for (int i = 0; i < mas3.GetLength(0); i++)
//{
//    for (int j = 0; j < mas3.GetLength(1); j++)
//    {
//        if (i == 0) mas3[i, j] = mas1[j];
//        else mas3[i, j] = mas2[j];
//        Console.Write(mas3[i,j]+" ");
//    }
//    Console.WriteLine();
//}

//int[,] mas = new int[12, 10];
//int count = 1;
//for (int i = 0; i < mas.GetLength(1); i++)
//{
//	for (int j = 0; j < mas.GetLength(0); j++)
//	{
//		mas[j, i] = count++;
//	}
//}
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i,j]+" ");
//    }
//    Console.WriteLine();
//}
int[,] mas = new int[12, 10];
int count = 1;
for (int i = mas.GetLength(0)-1; i>=0 ; i--)
{
	for (int j = mas.GetLength(1)-1; j>=0; j--)
	{
		mas[i, j] = count++;
	}
}
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
