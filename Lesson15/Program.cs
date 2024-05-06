//1.Написать программу для нахождения среднего значения элементов 
//двумерного массива. 

//Random random = new Random();
//double[,] mas = new double[random.Next(3, 10), random.Next(3, 10)];
//double s = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//	for (int j = 0; j < mas.GetLength(1); j++)
//	{
//		mas[i, j] = random.NextDouble() * 50;
//		Console.Write($"{mas[i, j]:F2} ");
//		s += mas[i, j];
//	}
//	Console.WriteLine();
//}
//Console.WriteLine($"Avg={s/(mas.GetLength(0)*mas.GetLength(1)):F2}");

//2.Написать программу для нахождения среднего значения каждой 
//строки двумерного массива. 
//Random random = new Random();
//double[,] mas = new double[random.Next(3, 10), random.Next(3, 10)];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    double s = 0;
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.NextDouble() * 50;
//        Console.Write($"{mas[i, j]:F2} ");
//        s += mas[i, j];
//    }
//    Console.WriteLine($"Avg={s / mas.GetLength(1):F2}");
//}

//3.Написать программу для транспонирования двумерного массива 
//(перевода строк в столбцы и наоборот). 
//Подсказка: вам понадобится 2 массива.

//Random random = new Random();
//int[,] mas = new int[random.Next(3, 10), random.Next(3, 10)];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        Console.Write(mas[i, j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//int[,] masdTrans = new int[mas.GetLength(1), mas.GetLength(0)];
//for (int i = 0; i < masdTrans.GetLength(0); i++)
//{
//    for (int j = 0; j < masdTrans.GetLength(1); j++)
//    {
//        masdTrans[i, j] = mas[j,i];
//        Console.Write(masdTrans[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Название проекта: Консольный планировщик задач. 
//Цель проекта: Создание консольного приложения на C#, позволяющего 
//пользователю добавлять, удалять, перезаписывать и выводить список 
//задач с их параметрами.
//int count = 0;
//Object[,] tasks=new Object[0,4];
//do
//{
//    Console.Clear();
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Меню:\n" +
//        "1 - Добавить задачу\n" +
//        "2 - Удалить задачу\n" +
//        "3 - Перезаписать задачу\n" +
//        "4 - Вывести список задач\n" +
//        "5 - Выход");
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.Write("Выберите пункт меню:");
//    int n=int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 1: 
//            { 
//                count++;
//                Object[,] temp= new Object[count,4];
//                Array.Copy(tasks, temp, tasks.Length);
//                Console.Write("Введите название задачи:");
//                temp[count-1, 0] = Console.ReadLine();
//                Console.Write("Введите дату задачи:");
//                temp[count - 1, 1] = Console.ReadLine();
//                Console.Write("Введите время задачи:");
//                temp[count - 1, 2] = Console.ReadLine();
//                Console.Write("Введите приоритет задачи:");
//                temp[count - 1, 3] =int.Parse(Console.ReadLine());
//                tasks = new Object[count, 4];
//                Array.Copy(temp, tasks, temp.Length);
//            } 
//            break;
//        case 2:
//            {
//                Console.Write("Введите номер задачи:");
//                int k = int.Parse(Console.ReadLine());
//                Object[,] temp = new Object[count-1, 4];
//                int size = 0;
//                for(int i = 0; i < count;i++)
//                {
//                    if (i != k - 1)
//                    {
//                        temp[size, 0] = tasks[i, 0];
//                        temp[size, 1] = tasks[i, 1];
//                        temp[size, 2] = tasks[i, 2];
//                        temp[size, 3] = tasks[i, 3];
//                        size++;
//                    }
//                }
//                count--;
//                tasks = new Object[count, 4];
//                Array.Copy(temp, tasks, tasks.Length);
//            }
//            break;
//        case 3:
//            {
//                Console.Write("Введите номер задачи:");
//                int k = int.Parse(Console.ReadLine());
//                Console.Write("Введите название задачи:");
//                tasks[k - 1, 0] = Console.ReadLine();
//                Console.Write("Введите дату задачи:");
//                tasks[k - 1, 1] = Console.ReadLine();
//                Console.Write("Введите время задачи:");
//                tasks[k - 1, 2] = Console.ReadLine();
//                Console.Write("Введите приоритет задачи:");
//                tasks[k - 1, 3] = int.Parse(Console.ReadLine());
//            }
//            break;
//        case 4:
//            {
//                Console.Clear();
//                for(int i = 0; i < count;i++)
//                {
//                    Console.WriteLine(i+1+". "+tasks[i,0]+" "+ tasks[i, 1] +" "+ tasks[i, 2] +" "+ tasks[i, 3]);
//                }
//                Console.ReadKey();
//            }
//            break;
//        case 5:break;
//        default: Console.WriteLine("Нет такого пункта меню");break;
//    }
//    if (n == 5) break;

//}
//while (true);

//int[,] mas = new int[6, 6];
//for (int i = 0; i < 6; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        if (i == 0) mas[i, j] = 1;
//        else if (j == 0) mas[i, j] = 1;
//        else
//        {
//           mas[i, j] = mas[i, j - 1] + mas[i-1,j];
//        }
//        Console.Write(mas[i,j]+" ");
//    }
//    Console.WriteLine();
//}

int[,] mas = new int[6, 6];
int k = 1;
for (int i = 0; i < 6; i++)
{
    int m = k;
    for (int j = 0; j < 6; j++)
    {
        if (m > 6) m = 1;
        mas[i, j] = m++;
        Console.Write(mas[i, j]+" ");
    }
    Console.WriteLine();
    k++;
}