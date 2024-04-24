//int[] mas1 = { 1, 4, 2, 7, 3 };//инициализация в коде
//int[] mas2= new int[5];
////ввод с клавиатуры
//for (int i = 0; i < mas2.Length; i++)
//{
//    Console.Write($"Введите {i + 1} элемент массива:");
//    mas2[i] = int.Parse(Console.ReadLine());
//}
//вывод элементов массива
//for (int i = 0; i < mas2.Length; i++)
//{
//    Console.Write(mas2[i] + " ");
//}
//Console.WriteLine();
//генерация по формуле
//int[] mas3=new int[5];
//for (int i = 0; i < mas3.Length; i++)
//{
//    mas3[i] = 2 * i + 1;
//    Console.Write(mas3[i]+" ");
//}
//Console.WriteLine();
//Генератор случайных чисел
//int[] mas4= new int[5];
//Random random = new Random();
//for (int i = 0; i < mas4.Length; i++)
//{
//    mas4[i] = random.Next(10, 100);
//    Console.Write(mas4[i] + " ");
//}
//Console.WriteLine();
//цикл foreach
//foreach(int p in mas4)
//{
//    Console.Write(p + " ");
//}
//Console.WriteLine();

//поиск элемента
//Console.Write("Введите число:");
//int k = int.Parse(Console.ReadLine());
//bool isFind=false;
//for (int i = 0; i < mas4.Length; i++)
//{
//    if(k == mas4[i])
//    {
//        Console.WriteLine($"Элемент найден по индексу {i}");
//        isFind=true;
//        break;
//    }
//}
//if(isFind==false) Console.WriteLine("Элемент не найден");

//Object[] mas6 = { 1, "rrr", 'a', 5.9 };
//foreach(var i in mas6)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();
////поиск max и min элементов
//int max = mas4[0];
//int min = mas4[0];
//for (int i = 1; i < mas4.Length; i++)
//{
//    if (mas4[i] > max) max = mas4[i];
//    if (mas4[i]<min) min = mas4[i];
//}
//Console.WriteLine(max+" "+min);

//1.Создайте одномерный массив с числами от 1 до 10. 
//int[] mas=new int[10];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = i + 1;
//    Console.Write(mas[i]+" ");
//}    
//Console.WriteLine();

//2.Создайте одномерный массив, состоящий из имен пользователей: 
//Дмитрий, Максим, Сергей, Андрей, Владислав. 
//Выведите на экран имя Максим. 
//Выведите все имена построчно используя цикл for. 

//string[] mas = { "Дмитрий привет", "Максим", "Сергей", "Андрей", "Владислав" };
//Console.WriteLine(mas[0]);
//foreach (string str in mas)
//{
//    Console.WriteLine(str+" ");
//}
//Console.WriteLine();

////3.Дополните предыдущий массив возможностью вывода имени по 
////порядковому номеру. От пользователя берется порядковый номер имени и это имя выводится на экран. 
//Console.Write("Введите порядковый номер:");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine(mas[n-1]);

//4.Создайте пустой строковый массив, с помощью цикла for заполните 
//его именами, принимаемыми от пользователя. 
//Выведите содержимое массива на экран. 
//Console.Write("Введите размер массива:");
//int n=int.Parse(Console.ReadLine());
//string[] mas = new string[n];
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write($"Введите {i + 1} имя:");
//    mas[i] = Console.ReadLine();
//}
//foreach (string q in mas) Console.Write(q + " ");
//Console.WriteLine();

//1.Создайте массив из 10 случайных целых чисел и найдите в нем сумму 
//всех элементов, кратных 3. 
//Random random = new Random();
//int[] mas = new int[10];
//int s = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(1,100);
//    Console.Write(mas[i]+" ");
//    if (mas[i] % 3 == 0) s += mas[i];
//}
//Console.WriteLine();
//Console.WriteLine("sum="+s);

//2.Создайте массив из 20 случайных действительных чисел и
//найдите в нем индекс первого отрицательного элемента.
//double[] mas= new double[20];
//Random random= new Random();
//for (int i = 0; i <mas.Length; i++)
//{
//    mas[i]=random.NextDouble()*200-50;
//    Console.Write($"{mas[i]:F2} ");
//}
//Console.WriteLine();
//for (int i = 0;i < mas.Length; i++)
//{
//    if (mas[i]<0)
//    {
//        Console.WriteLine($"Индекс первого отрицательного {i}");
//        break;
//    }
//}

//3.Создайте массив из 15 случайных целых чисел и выведите на экран 
//только те элементы, которые делятся на 2 и не делятся на 3. 
//int[] mas = new int[15];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(100);
//    if (mas[i] % 2 == 0 && mas[i]%3!=0)Console.Write($"{mas[i]} ");
//}
//Console.WriteLine();
//4.Создайте массив из 12 случайных целых чисел и найдите в нем 
//наибольший элемент, наименьший элемент и среднее арифметическое 
//всех элементов.
//using System.Threading.Channels;

//int[] mas = new int[12];
//Random random = new Random();
//int max = int.MinValue;
//int min = int.MaxValue;
//double s = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i]=random.Next(100);
//    Console.Write(mas[i]+" ");
//    if (mas[i] > max) max = mas[i];
//    if (mas[i] < min) min = mas[i];
//    s += mas[i];
//}
//Console.WriteLine();
//Console.WriteLine("max="+max + " min=" + min);
//Console.WriteLine($"avg={s / mas.Length:F2}");

//5.Создайте массив из 8 строк и найдите в нем самую короткую и самую 
//длинную строку, а также выведите на экран все строки, содержащие 
//букву "а". 

//string[] mas=new string[8];
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write($"Введите {i + 1} строку:");
//    mas[i] = Console.ReadLine();
//}
//int max = mas[0].Length;
//int min= mas[0].Length;
//string maxStr = mas[0];
//string minStr = mas[0];
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i].Length > max)
//    {
//        max = mas[i].Length;
//        maxStr = mas[i];
//    }
//    if (mas[i].Length < min)
//    {
//        min = mas[i].Length;
//        minStr = mas[i];
//    }
//    if (mas[i].Contains("a")|| mas[i].Contains("A")) 
//        Console.Write(mas[i] + " ");
//}
//Console.WriteLine("max=" + maxStr + " min=" + minStr);

//6.Создайте массив из 30 случайных целых чисел и выведите на экран 
//все элементы, которые встречаются в массиве больше одного раза.
int[] mas= new int[30];
Random random=new Random();
for (int i = 0; i < mas.Length; i++)
{
	mas[i] = random.Next(50);
	Console.Write(mas[i]+" ");	
}
Console.WriteLine();
int[] masWithoutRepeat= new int[30];
int k = 0;
for (int i = 0;i<mas.Length-1;i++)
{
	for (int j = i+1; j < mas.Length; j++)
	{
		if (mas[i] == mas[j])
		{
			bool isTrue=false;
			for(int l = 0; l < k; l++)
			{
				if (masWithoutRepeat[l] == mas[i])
				{
					isTrue=true;
					break;
				}
			}
			if(isTrue==false) masWithoutRepeat[k++] = mas[i];
		}
	}
}
for(int i = 0; i < k; i++)
{
	Console.Write(masWithoutRepeat[i]+" ");
}
Console.WriteLine();