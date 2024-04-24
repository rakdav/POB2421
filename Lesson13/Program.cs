//using System.Diagnostics;

//Random random = new Random();
//int[] mas = new int[100000];
//int[] copyMas = new int[100000];

//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(50);
//   // Console.Write(mas[i] + " ");
//}
//Array.Copy(mas,copyMas,mas.Length);
//Console.WriteLine();
//Stopwatch stpWatch = new Stopwatch();
//stpWatch.Start();
//for (int i = 0; i < mas.Length - 1; i++)
//{
//    for (int j = i + 1; j < mas.Length; j++)
//    {
//        if (mas[i] > mas[j])
//        {
//            int temp = mas[i];
//            mas[i] = mas[j];
//            mas[j] = temp;
//        }
//    }
//}
//stpWatch.Stop();
//Console.WriteLine("StopWatch: " +(stpWatch.ElapsedMilliseconds/1000.0).ToString());

//Stopwatch stpWatch1 = new Stopwatch();
//stpWatch1.Start();
//Array.Sort(copyMas);
//stpWatch1.Stop();
//Console.WriteLine("StopWatch: " + (stpWatch1.ElapsedMilliseconds / 1000.0).ToString());


//int[] mas2 = new int[random.Next(10, 31)];
//Array.Fill(mas, 5);//заполняет массив одним и тем же числом
//for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
//Console.WriteLine();
//Array.Fill(mas, 4, mas.Length / 2,3);
//for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
//Console.WriteLine();
//int[] mas3 = new int[mas.Length];
//Array.Copy(mas, mas3, mas.Length);//копирует массив
//for (int i = 0; i < mas3.Length; i++) Console.Write(mas3[i] + " ");
//Console.WriteLine();
//Console.WriteLine(Array.IndexOf(mas2,4));
//Console.WriteLine(Array.LastIndexOf(mas2, 4));
//Array.Sort(mas2);
//for (int i = 0; i < mas3.Length; i++) Console.Write(mas3[i] + " ");
//Console.WriteLine();
//Console.WriteLine(Array.BinarySearch(mas3,5));
//Array.Sort(mas);
//for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
//Console.WriteLine();
//Console.Write("Введите число:");
//int n=int.Parse(Console.ReadLine());
//Console.WriteLine(Array.BinarySearch(mas,n));
//Console.WriteLine(mas.Rank);
//Array.Reverse(mas);
//for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
//Console.WriteLine();
//Array.Clear(mas);
//for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");

//Stopwatch stpWatch = new Stopwatch();
//stpWatch.Start();
//stpWatch.Stop();
//Console.WriteLine("StopWatch: " +
//stpWatch.ElapsedMilliseconds.ToString());

//1.Напишите программу, которая запрашивает у пользователя 5 чисел и 
//сохраняет их в массиве. Затем программа выводит на экран все числа 
//из массива в обратном порядке. 
//Random random = new Random();
//int[] mas = new int[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i]=random.Next(1,10);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//Array.Reverse(mas);
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write(mas[i] + " ");
//}
//2.Напишите программу, которая запрашивает у пользователя 5 слов и 
//сохраняет их в массиве. Затем программа находит и выводит самое 
//длинное слово из массива. 
//string[] mas = new string[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write("Введите слово:");
//    mas[i] = Console.ReadLine();
//}
//int max = mas[0].Length;
//string masStr = mas[0];
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i].Length > max)
//    {
//        max = mas[i].Length;
//        masStr = mas[i]; 
//    }
//}
//Console.WriteLine(masStr);

//3.Создайте 2 массива случайных чисел. Соедините их с помощью 
//метода Concat(). Затем программа находит и выводит среднее 
//арифметическое всех чисел в массиве. 
//Random random = new Random();
//int[] mas1 = new int[random.Next(5,16)];
//int[] mas2=new int[random.Next(5,16)];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.Next(20);
//    Console.Write(mas1[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.Length; i++)
//{
//    mas2[i] = random.Next(20);
//    Console.Write(mas2[i] + " ");
//}
//Console.WriteLine();
//int[] masSum=mas1.Concat(mas2).ToArray();

//for (int i = 0; i < masSum.Length; i++)
//{
//    Console.Write(masSum[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine($"{masSum.Average():F2}");

//4.Напишите программу, которая запрашивает у пользователя 10 чисел 
//и сохраняет их в массиве. Затем программа находит и выводит на экран 
//наименьшее и наибольшее число в массиве. 

//Random random = new Random();
//int[] mas = new int[10];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(20);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine("Max=" + mas.Max());
//Console.WriteLine("Min=" + mas.Min());

//5.Напишите программу, которая запрашивает у пользователя 5 слов и 
//сохраняет их в массиве. Затем программа выводит на экран все слова 
//из массива, начинающиеся на определенную букву, которую вводит 
//пользователь. Для данной задачи используйте метод “IndexOf()”

string[] mas = new string[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write("Введите слово:");
//    mas[i] = Console.ReadLine();
//}
//Console.Write("Введите букву:");
//char c = char.Parse(Console.ReadLine());
//foreach(string s in mas)
//{
//    if (s.IndexOf(c) == 0) Console.WriteLine(s); 
//}

Console.WriteLine(mas.GetHashCode());   

