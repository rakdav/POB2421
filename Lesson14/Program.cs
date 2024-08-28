//Random random = new Random();
//int[,] mas = new int[4, 4];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//	for (int j = 0; j < mas.GetLength(1); j++)
//	{
//		mas[i, j] = random.Next(-5, 6);
//		Console.Write(mas[i, j] + " ");
//	}
//	Console.WriteLine();
//}
//int min = mas[0, 0];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if(mas[i, j]<min) min=mas[i, j];
//    }
//}
//Console.WriteLine("min="+min);
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (mas[i, j] % 2 == 0) mas[i, j] *= 2;
//        else mas[i, j] *= 3;
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//min = mas[0, 0];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (mas[i, j] < min) min = mas[i, j];
//    }
//}

//1.Написать программу для нахождения суммы элементов двумерного 
//массива. 
//2. Написать программу для нахождения произведения элементов 
//двумерного массива. 

//Console.WriteLine("min=" + min);
//Console.Write("Введите количество строк:");
//int n=int.Parse(Console.ReadLine());
//Console.Write("Введите количество столбцов:");
//int m = int.Parse(Console.ReadLine());
//int[,] mas=new int[n,m];
//Random random=new Random();
//int s = 0;
//long p = 1;
//for(int i = 0; i < mas.GetLength(0); i++)
//{
//    for(int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        Console.Write(mas[i, j] + " ");
//        s += mas[i, j];
//        p *= mas[i, j];
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Sum="+s);
//Console.WriteLine("P="+p);

//3.Написать программу, выводящую элементы двумерного массива по 
//диагонали. 
//Console.Write("Введите количество строк:");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Введите количество столбцов:");
//int m = int.Parse(Console.ReadLine());
//int[,] mas = new int[n, m];
//Random random = new Random();
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//int s = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        for (int k =0;k<s;k++) Console.Write(" ");
//        Console.WriteLine(mas[i, j]);
//        s++;
//    }
//}

//4.Написать программу — телефонный справочник — создать 
//двумерный массив 5*3, хранящий 
//список телефонных контактов: первый элемент хранит имя контакта,
//второй — номер, третий e-mail 
//2.1 Вывести все элементы массива на экран. 
//2.2 Вывести три элемента: имя, номер и e-mail по запросу пользователя 
//по имени.
//string[,] mas =
//{
//    {"first","1234","first@gmail.com"},
//    {"second","2234","second@gmail.com"},
//    {"third","3234","third@gmail.com"},
//    {"four","4234","four@gmail.com"},
//    {"five","5234","five@gmail.com"}
//};

//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for(int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Console.Write("Введите имя:");
//string name=Console.ReadLine();
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    if (mas[i, 0] == name) 
//        Console.WriteLine(mas[i, 0]+" " + mas[i, 1]+" " + mas[i,2]);
//}

//int[,] mas=new int[7,7];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        //if(i==j||i+j==mas.GetLength(0)-1||j==mas.GetLength(1)/2||
//        //    i==mas.GetLength(0)/2) mas[i, j] = 1;
//        if((i<=j&&i+j<=mas.GetLength(0)-1)||(i>=j&&i+j>=mas.GetLength(0)-1)) mas[i, j] = 1;
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine((int)'0');
//Console.WriteLine((int)'z');
//for (int i = (int)'0'; i <=(int)'z'; i++)
//{
//    Console.WriteLine(i);
//}
Random random = new Random();
Console.WriteLine("Введите длину пароля:");
int n = int.Parse(Console.ReadLine());
string password = "";
for (int i = 0; i < n; i++)
{
    int m = random.Next(48,123);
    password += (char)m;
}
Console.WriteLine(password);