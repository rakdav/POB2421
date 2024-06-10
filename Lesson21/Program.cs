//Задача 1: Создание резервной копии файла
//Попросите пользователя ввести имя файла и имя файла резервной копии.
//Создайте резервную копию указанного файла.

//Console.Write("Введите имя файла:");
//string fileName = Console.ReadLine()!;
//FileInfo info = new FileInfo(fileName);
//if (info.Exists)
//{
//    Console.Write("Введите имя файла замены:");
//    string fileNameReplace = Console.ReadLine()!;
//    info.Replace(fileNameReplace,"Arch.txt");
//}

//Задача 2: Поиск самого большого файла в папке
//Попросите пользователя ввести путь к папке.
//Найдите самый большой файл в указанной папке и выведите его имя и
//размер на экран.
//Console.Write("Введите путь к папке:");
//string folderPath = Console.ReadLine()!;
//DirectoryInfo dir = new DirectoryInfo(folderPath);
//long max = 0;
//string maxFile = String.Empty;
//foreach(FileInfo info in dir.GetFiles())
//{
//    if(info.Length>max)
//    {
//        max = info.Length;
//        maxFile = info.Name;
//    }
//}
//Console.WriteLine(maxFile+" "+max);

//Задача 3: Подсчет количества файлов в папке
//Попросите пользователя ввести путь к папке.
//Посчитайте количество файлов в указанной папке и выведите результат на
//экран.
//Console.WriteLine("Количество файлов в папке:"+dir.GetFiles().Length);

//Задача 4: Поиск дубликатов файлов
//Попросите пользователя ввести путь к папке.
//Найдите все дубликаты файлов (файлы с одинаковым содержимым) в
//указанной папке и выведите их имена на экран.
//Console.Write("Введите путь к папке:");
//string folderPath = Console.ReadLine()!;
//DirectoryInfo dir = new DirectoryInfo(folderPath);
//for (int i = 0; i < dir.GetFiles().Length - 1; i++)
//{
//    for (int j = i + 1; j < dir.GetFiles().Length; j++)
//    {
//            string text1 = File.ReadAllText(dir.GetFiles()[i].FullName);
//            string text2 = File.ReadAllText(dir.GetFiles()[j].FullName);
//            if (text1 == text2)
//            {
//                Console.WriteLine(dir.GetFiles()[i].Name + " " + dir.GetFiles()[j].Name);
//            }
//    }
//}

//Задача 5: Создание директорий
//Попросите пользователя ввести имя директории.
//Создайте новую директорию с указанным именем.

//Console.Write("Введите название директория:");
//string dirName = Console.ReadLine()!;
//DirectoryInfo dir = new DirectoryInfo(dirName);
//if(!dir.Exists) dir.Create();

//Задача 6: Поиск файлов, измененных за последние N дней
//Попросите пользователя ввести путь к папке и количество дней.
//Найдите все файлы, измененные в указанной папке за последние N дней и
//выведите их имена на экран

//Console.Write("Введите путь к папке:");
//string folderPath = Console.ReadLine()!;
//DirectoryInfo dir = new DirectoryInfo(folderPath);
//Console.Write("Введите количество дней");
//int n = int.Parse(Console.ReadLine()!);
//if (dir.Exists)
//{
//    foreach(FileInfo file in dir.GetFiles())
//    {
//        if ((DateTime.Now - file.LastWriteTime).Days < n)
//        {
//            Console.WriteLine(file.Name + " " + file.LastWriteTime);
//        }
//    }
//}

//Напишите программу, используя функции, которые в зависимости от
//выбора пользователя будут: создавать файл, читать содержимое файла,
//удалять файл, создавать и удалять директорию.
//*Выводить список содержимого папки
//using System.Runtime.CompilerServices;

//void CreateFile(string fileName)
//{
//    FileInfo fileInfo = new FileInfo(fileName);
//    if (!fileInfo.Exists) fileInfo.Create();
//    else Console.WriteLine("Файл существует");
//}
//string getText(string fileName)
//{
//    return File.ReadAllText(fileName);
//}
//void RemoveFile(string fileName)
//{
//   if(File.Exists(fileName)) File.Delete(fileName);
//    else Console.WriteLine("Файл не существует");
//}
//void CreateDirectory(string fileName)
//{
//    DirectoryInfo dir = new DirectoryInfo(fileName);
//    if (!dir.Exists) dir.Create();
//    else Console.WriteLine("Директорий существует");
//}
//void DeleteDirectory(string fileName)
//{
//    if (Directory.Exists(fileName)) Directory.Delete(fileName);
//    else Console.WriteLine("Директорий не существует");
//}
//do
//{
//    Console.Clear();
//    Console.WriteLine("Меню\n 1 - Создать файл\n" +
//        "2 - считать содержимое файла\n" +
//        "3 - удалить файл\n" +
//        "4 - удалить директорию\n" +
//        "Выберите действие:");
//    int n = int.Parse(Console.ReadLine()!);
//    switch (n)
//    {
//        case 1: 
//            {
//                Console.Write("Введите название файла:");
//                string fileName = Console.ReadLine()!;
//                CreateFile(fileName);
//            } 
//            break;
//        case 2: 
//            {
//                Console.Write("Введите название файла:");
//                string fileName = Console.ReadLine()!;
//                Console.WriteLine(getText(fileName));

//            } break;
//        case 3: 
//            {
//                Console.Write("Введите название файла:");
//                string fileName = Console.ReadLine()!;
//                RemoveFile(fileName);
//            } break;
//        case 4: 
//            {
//                Console.Write("Введите название директория:");
//                string fileName = Console.ReadLine()!;
//                CreateDirectory(fileName);
//            }
//            break;
//        case 5:
//            {
//                Console.Write("Введите название директория:");
//                string fileName = Console.ReadLine()!;
//                DeleteDirectory(fileName);
//            }
//            break;
//        case 6:
//            Environment.Exit(0);
//            break;
//    }
//    Console.ReadKey();
//}
//while (true);


//Задание 1:
//Напишите программу, которая позволяет пользователю создать новую
//папку в текущей директории. Программа должна запрашивать название
//папки у пользователя и создавать ее. Если папка с таким названием уже
//существует, программа должна выводить сообщение об ошибке и
//попросить пользователя ввести другое название.

bool CreateDirectory(string fileName)
{
    DirectoryInfo dir = new DirectoryInfo(fileName);
    if (!dir.Exists)
    {
        dir.Create();
        return true;
    }
    else Console.WriteLine("Директорий существует");
    return false;
}
string fileName="";
do
{
    Console.Write("Введите название папки:");
    fileName = Console.ReadLine()!;
}
while(CreateDirectory(fileName)==false);

