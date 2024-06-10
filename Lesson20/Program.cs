using System;
using System.Text;

//FileStream

//FileStream fs = null;
//try
//{
//    fs = new FileStream("file.txt", FileMode.Open);
//    byte[] b = new byte[1024];
//    UTF8Encoding temp = new UTF8Encoding(true);
//    while (fs.Read(b,0,b.Length)>0)
//    {
//        Console.WriteLine(temp.GetString(b));
//    }
//}
//catch(IOException e)
//{
//    Console.WriteLine(e.Message);
//}
//finally
//{
//    if(fs!=null)
//        fs.Close();
//}

//using (FileStream fs=new FileStream("file.txt",FileMode.Open))
//{
//    byte[] b = new byte[1024];
//    UTF8Encoding temp = new UTF8Encoding(true);
//    while (fs.Read(b, 0, b.Length) > 0)
//    {
//        Console.WriteLine(temp.GetString(b));
//    }
//}

//using (FileStream fs=new FileStream("newfile.txt",FileMode.Create))
//{
//    Console.Write("Введите текст:");
//    string str = Console.ReadLine();
//    byte[] info = new UTF8Encoding(true).GetBytes(str);
//    fs.Write(info, 0, info.Length);
//}

//string path = @"C:\Users\c7pct\source\repos\POB2421\Lesson20\bin\Debug\net8.0\newasync.txt";
//Console.Write("Введите текст:");
//string str = Console.ReadLine();
//using (FileStream fstream=new FileStream(path, FileMode.OpenOrCreate))
//{
//    byte[] buffer = Encoding.Default.GetBytes(str);
//    await fstream.WriteAsync(buffer,0,buffer.Length);
//}

//using(FileStream fstream=new FileStream(path, FileMode.Open))
//{
//    byte[] buffer = new byte[fstream.Length];
//    await fstream.ReadAsync(buffer, 0, buffer.Length);
//    string text = Encoding.Default.GetString(buffer);
//    Console.WriteLine(text);
//}

////Произвольный доступ к файлам
//string path = "note.txt";
//string text = "Hello, world";

//using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
//{
//    byte[] buffer = Encoding.Default.GetBytes(text);
//    await fstream.WriteAsync(buffer, 0, buffer.Length);
//}

//using(FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
//{
//    // fstream.Seek(-5, SeekOrigin.End);
//    fstream.Seek(0, SeekOrigin.Begin);
//    byte[] output = new byte[5];
//    await fstream.ReadAsync(output, 0, output.Length);
//    Console.WriteLine(Encoding.Default.GetString(output));
//}

////StreamReader и SreamWriter
//string path = "note.txt";
//string text = "Hello, world";

//using (StreamWriter writer = new StreamWriter(path, false))
//{
//    await writer.WriteLineAsync(text);
//}

//using (StreamWriter writer = new StreamWriter(path, true))
//{
//    await writer.WriteAsync("and me");
//    await writer.WriteAsync("4.5");
//}

//using(StreamReader reader=new StreamReader(path))
//{
//    string textRead = await reader.ReadToEndAsync();
//    Console.WriteLine(textRead);
//}

//using (StreamReader reader = new StreamReader(path))
//{
//    string line;
//    while((line=await reader.ReadLineAsync()) != null)
//    {
//        Console.WriteLine(line);
//    }
//}

//Задача 1: Создание файла
//Попросите пользователя ввести имя файла и его содержимое.
//Создайте файл с указанным именем и запишите в него указанное
//содержимое.
//Console.Write("Укажите название файла:");
//string fileName = Console.ReadLine();
//FileInfo file = new FileInfo(fileName);
//using (FileStream fs = file.Create()) {
//    Console.Write("Введите текст файла:");
//    string text = Console.ReadLine();
//    byte[] buffer = Encoding.Default.GetBytes(text);
//    await fs.WriteAsync(buffer, 0, buffer.Length);
//}

//Задача 2: Чтение файла
//Попросите пользователя ввести имя файла.
//Прочитайте содержимое указанного файла и выведите его на экран.
//Console.Write("Введите имя файла для чтения:");
//string fileName = Console.ReadLine();
//using (StreamReader reader = new StreamReader(fileName))
//{
//    string textRead = await reader.ReadToEndAsync();
//    Console.WriteLine(textRead);
//}
//Console.WriteLine(await File.ReadAllTextAsync(fileName));

//Задача 3: Копирование файла
//Попросите пользователя ввести имя исходного файла и имя файла
//назначения.
//Скопируйте содержимое исходного файла в файл назначения.

//Console.Write("Введите имя файла:");
//string sourceName = Console.ReadLine();
//Console.Write("Введите файл копии:");
//string destName = Console.ReadLine();
//FileInfo info = new FileInfo(sourceName);
//if (info.Exists)
//{
//    info.CopyTo(destName,true);
//}

//Задача 4: Поиск файлов по расширению
//Попросите пользователя ввести путь к папке и расширение файла.
//Найдите все файлы с указанным расширением в указанной папке и
//выведите их имена на экран.
//Console.Write("Введите путь к папке:");
//string path = Console.ReadLine();
//Console.Write("Введите расширение файла:");
//string extension = Console.ReadLine();
//DirectoryInfo dir = new DirectoryInfo(path);
//foreach(FileInfo file in dir.GetFiles())
//{
//    if (file.Extension == extension) Console.WriteLine(file.Name);
//}

//Задача 5: Удаление файла
//Попросите пользователя ввести имя файла для удаления.
//Удалите указанный файл, если он существует.

//Console.Write("Введите имя файла для удаления:");
//string delFile = Console.ReadLine();
//FileInfo file = new FileInfo(delFile);
//if (file.Exists)
//{
//    file.Delete();
//}

//Задача 6: Переименование файла
//Попросите пользователя ввести текущее имя файла и новое имя файла.
//Переименуйте указанный файл, если он существует

Console.WriteLine("Введите имя файла:");
string fileName = Console.ReadLine()!;
FileInfo info = new FileInfo(fileName);
if (info.Exists)
{
    Console.WriteLine("Введите новое имя файла:");
    string newFileName = Console.ReadLine()!;
    info.MoveTo(newFileName);
}

