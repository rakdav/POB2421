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

//string[] mas = new string[5];
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

//Object obk=new object();
//Console.WriteLine(obk.GetHashCode());
//Console.WriteLine(obk.ToString());
//obk = 5;
//int a = 5;
//Console.WriteLine(obk.Equals(a));
//Console.WriteLine(obk.GetType());
//if (obk.GetType() == typeof(int))
//{
//    Console.WriteLine("Целый тип");
//}

//Задание 1. 
//● Инициализируйте генератор случайных значений. 
//● Объявите переменные и укажите в них значения имен 
//пользователей. Необходимо 6 разных имен. 
//● Создайте пустой одномерный строковый массив размером в 6 
//ячеек. 
//● С помощью генератора, в случайном порядке заполните массив 
//именами из переменных. 
//● Выведите значения массива на экран, в строку. 
//● Задача: 
//После объявления массива имен, от пользователя берутся имена,
//которые необходимо удалить и удаляются, заменяясь на “Удален” 
//Затем, необходимо вывести список имен без “Удален”. 
//using System.Diagnostics;

//Random random = new Random();
//string name1 = "Вася";
//string name2 = "Ваня";
//string name3 = "Боря";
//string name4 = "Леша";
//string name5 = "Егор";
//string name6 = "Коля";
//string[] names = new string[6];
//int i = 0;
//do
//{
//    int n=random.Next(1,7);
//    string temp=String.Empty;
//    switch (n)
//    {
//        case 1:
//            temp = name1;
//            break;
//        case 2:
//            temp = name2;
//            break;
//        case 3:
//            temp= name3;
//            break;
//        case 4:
//            temp = name4;
//            break;
//        case 5:
//            temp = name5;
//            break;
//        case 6:
//            temp = name6;
//            break;
//    }
//    if (!names.Contains(temp))
//    {
//        names[i++] = temp;
//        if (i == 6) break;
//    }
//}
//while (true);
//foreach(string name in names) Console.Write(name+" ");
//Console.WriteLine();
//Console.Write("Введите имена для удаления через пробел:");
//string namesDel = Console.ReadLine();
//string[] mas = namesDel.Split(' ');
//foreach(string name in mas)
//{
//    int index=Array.IndexOf(names,name);
//    if (index != -1) names[index] = "Удален";
//}
//foreach (string name in names)
//    if (name != "Удален") Console.Write(name + " ");

//Задание 2. 
//Создать 2 массива, создать цикл, заполняющий их случайными числами. Создать 3й массив, заполняемый разностями чисел первого и второго массива. 
//using System.Threading.Channels;

//Random random = new Random();
//int[] mas1 = new int[10];
//int[] mas2 = new int[10];
//int[] mas3 = new int[10];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i]=random.Next(10,100);
//    mas2[i]=random.Next(10,100);
//    mas3[i] = mas1[i] - mas2[i];
//}
//for (int i = 0; i < mas1.Length; i++)
//{
//    Console.Write(mas1[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.Length; i++)
//{
//    Console.Write(mas2[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0;i < mas3.Length; i++)
//{
//    Console.Write(mas3[i]+" ");
//}
//Console.WriteLine();

//Задание 3. 
//Создать массив объектов, вывести его значения в обратном порядке и 
//соединить их в строку, в которой, впоследствии, методом Substring() 
//срезать половину символов (подсчитанных программно). 

//Object[] mas= new Object[6];
//for(int i=0; i<6; i++)
//{
//    Console.Write($"Введите {i + 1} элемент:");
//    mas[i] = Console.ReadLine();
//}
//string res = "";
//Array.Reverse(mas);
//for (int i = 0;i<mas.Length;i++)
//    res += mas[i];
//Console.WriteLine(res);
//res=res.Substring(0,res.Length/2);
//Console.WriteLine(res);

Random random = new Random();
int[] mas1 = new int[10];
int[] mas2 = new int[10];
int[] mas3 = new int[10];
double[] mas4 = new double[10]; 
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(10, 100);
    mas2[i] = random.Next(10, 100);
    mas3[i] = random.Next(10, 100);
    double s = (mas1[i] + mas2[i] + mas3[i]) / 3.0;
    mas4[i] = s;
}
for (int i = 0; i < mas4.Length; i++)
{
    Console.Write($"{mas4[i]:F2} ");
}
Console.WriteLine();
