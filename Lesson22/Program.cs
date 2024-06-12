//using System;
//double Division(double a,double b)
//{
//    if (b != 0) return a / b;

//    throw new DivideByZeroException("Делить на ноль нельзя!");
//}
//do
//{
//    FileStream? fs=null;
//    try
//    {
//        Console.Write("Введите первое положительное число:");
//        int n = int.Parse(Console.ReadLine()!);
//        if (n < 0) throw new Exception("Введено отрицательное число!"); 
//        Console.Write("Введите второе положительное число:");
//        int m = int.Parse(Console.ReadLine()!);
//        Console.WriteLine(Division(n,m));
//        int[] mas=new int[5];
//        Console.WriteLine(mas[3]);
//        Random random=new Random();
//        mas[0] = random.Next(10);
//        fs = new FileStream("text.txt",FileMode.Open);
//    }
//    catch(FormatException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch(ArithmeticException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch(IndexOutOfRangeException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch(IOException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine("Ошибка:"+e.Message);
//    }
//    finally
//    {
//        if (fs != null) fs.Close();
//    }
//} while (true);

//Задание 2.
//Создайте метод, который открывает файл по указанному пути и выводит
//его содержимое на консоль. Обработайте исключение, которое может
//возникнуть, если файл не существует.

//using System.Text;

//try
//{
//    FileInfo finfo = new FileInfo("text.txt");
//    using (FileStream fs = finfo.Open(FileMode.Open))
//    {
//        byte[] b = new byte[1024];
//        Encoding temp = Encoding.Default;
//        while (fs.Read(b, 0, b.Length) > 0)
//        {
//            Console.WriteLine(temp.GetString(b));
//        }
//    }
//}
//catch (IOException e)
//{
//    Console.WriteLine(e.Message);
//}

//Задание 3.
//Напишите программу, которая запрашивает у пользователя число и
//выводит его квадратный корень. Обработайте исключение, которое может
//возникнуть, если введено отрицательное число.

//try
//{
//    Console.Write("Введите положительное число:");
//    int n = int.Parse(Console.ReadLine()!);
//    if (n < 0) throw new Exception("Корень от отрицательного числа!!!");
//    Console.WriteLine(Math.Sqrt(n));
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Задание 4.
//Создайте метод, который пытается преобразовать введенную
//пользователем строку в число и выводит результат на консоль.
//Обработайте исключение, которое может возникнуть, если введена
//некорректная строка.

//try
//{
//    Console.Write("Введите первое положительное число:");
//    int n = int.Parse(Console.ReadLine()!);
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Задание 5.
//Напишите программу, которая читает содержимое файла и записывает его
//в другой файл. Обработайте исключения, которые могут возникнуть при
//чтении или записи файлов

//try
//{
//    Console.Write("Введите название файла чтения:");
//    string readFile = Console.ReadLine()!;
//    Console.Write("Введите название файла записи:");
//    string writeFile = Console.ReadLine()!;
//    await File.WriteAllTextAsync(writeFile,
//        await File.ReadAllTextAsync(readFile));
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

string current=Environment.CurrentDirectory;
do
{
    Console.Write(current+">");
    string command = Console.ReadLine()!;
    string[] commands = command.Split(" ");
    switch (commands[0])
    {
        case "dir":case "ls":
            {
                DirectoryInfo dirs = new DirectoryInfo(current);
                foreach(var f in dirs.GetFileSystemInfos())
                {
                    Console.WriteLine(f.Name);
                }
            }
            break;
        case "cd":
            {
                switch (commands[1])
                {
                    case "/":
                        {
                            DirectoryInfo dirs = new DirectoryInfo(current);
                            current = dirs.Root.FullName;
                        }
                        break;
                    case "..":
                        {
                            try
                            {
                                DirectoryInfo dirs = new DirectoryInfo(current);
                                if (dirs.Parent!.FullName != null) current = dirs.Parent!.FullName;
                                else throw new NullReferenceException("Там только боги!!!");
                            }
                            catch(NullReferenceException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    default:
                        {
                            if (Directory.Exists(commands[1])) current = new DirectoryInfo(commands[1]).FullName;
                            else Console.WriteLine("Не такого каталога");
                        }
                        break;
                }
            }
            break;

    }
}
while (true);

