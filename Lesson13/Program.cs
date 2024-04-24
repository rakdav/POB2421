using System.Diagnostics;

Random random = new Random();
int[] mas = new int[100000];
int[] copyMas = new int[100000];

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(50);
   // Console.Write(mas[i] + " ");
}
Array.Copy(mas,copyMas,mas.Length);
Console.WriteLine();
Stopwatch stpWatch = new Stopwatch();
stpWatch.Start();
for (int i = 0; i < mas.Length - 1; i++)
{
    for (int j = i + 1; j < mas.Length; j++)
    {
        if (mas[i] > mas[j])
        {
            int temp = mas[i];
            mas[i] = mas[j];
            mas[j] = temp;
        }
    }
}
stpWatch.Stop();
Console.WriteLine("StopWatch: " +(stpWatch.ElapsedMilliseconds/1000.0).ToString());

Stopwatch stpWatch1 = new Stopwatch();
stpWatch1.Start();
Array.Sort(copyMas);
stpWatch1.Stop();
Console.WriteLine("StopWatch: " + (stpWatch1.ElapsedMilliseconds / 1000.0).ToString());


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



