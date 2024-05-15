//Задача 1: Проверка наличия слова в строке 
//Напишите программу, которая запрашивает у пользователя ввод строки 
//и слова. Затем программа должна использовать метод Contains() для 
//проверки, содержит ли введенная строка указанное слово. Выведите 
//сообщение о результате проверки наличия слова в строке. 

//Console.Write("Введите строку:");
//string str=Console.ReadLine();  
//Console.Write("Введите слово:");
//string word=Console.ReadLine();
//if (str.Contains(word)) Console.WriteLine("Строка содержит указанное слово.");
//else Console.WriteLine("Строка не содержит указанное слово.");

//Задача 2: Замена символов в строке 
//Напишите программу, которая запрашивает у пользователя ввод строки 
//и символа, который нужно заменить, а также символа, на который нужно заменить. 
//Затем программа должна использовать метод Replace() для замены 
//указанного символа на другой символ во введенной строке. Выведите 
//обновленную строку на экран. 

//using System.Globalization;

//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//Console.Write("Введите символ, который нужно заменить:");
//char symbol1 = char.Parse(Console.ReadLine());
//Console.Write("Введите символ,на который нужно заменить:");
//char symbol2 = char.Parse(Console.ReadLine());
//str = str.Replace(symbol1, symbol2);
//Console.WriteLine(str);

//Задача 3: Подсчет количества вхождений слова
//Напишите программу, которая запрашивает у пользователя
//ввод строки и слова. Затем программа должна использовать
//метод Contains() и цикл для подсчета количества вхождений
//указанного слова во введенной строке. Выведите количество
//вхождений на экран.

//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//Console.Write("Введите слово для подсчета:");
//string word = Console.ReadLine();
//int count = 0;
//str = str.ToLower();
//while (str.Contains(word))
//{
//    count++;
//    int index=str.IndexOf(word);
//    str=str.Remove(0, index+word.Length);
//}
//Console.WriteLine("Количество вхождений:"+count);

//Задача 4*: Замена определенных значений
//Напишите программу, которая запрашивает у
//пользователя слово и заменяет все его вхождения на *
//посимвольно.

//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//Console.Write("Введите слово:");
//string word = Console.ReadLine();
//string replace = "";
//for (int i = 0; i < word.Length; i++) replace += "*";
//while (str.Contains(word))
//{
//    str = str.Replace(word,replace);
//}
//Console.WriteLine(str);

//Задание 1. Разделение полного имени на отдельные компоненты: 
//Пользователь вводит полное имя в формате "Имя Фамилия". 
//Используя метод Split, разделите полное имя на две отдельные строки - 
//имя и фамилию. 
//Выведите полученные значения на экран. 

//Console.Write("Введите фамилию и имя:");
//string str = Console.ReadLine();
//string[] mas = str.Split(' ');
//foreach (string i in mas) Console.WriteLine(i);

//Задание 2. Обработка списка элементов: 
//Пользователь вводит список элементов, разделенных запятой, например,
//"яблоко,банан,апельсин". 
//Используя метод Split и указав запятую в качестве разделителя,
//разделите список элементов на отдельные строки. 
//Выведите каждый элемент списка на отдельной строке. 

//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//string[] mas = str.Split(',');
//foreach (string i in mas) Console.WriteLine(i);

//Задание 3. Разделение текста на предложения: 
//Пользователь вводит текст, содержащий несколько предложений. 
//Используя метод Split и символы ".", "!" и "?", разделите текст на 
//отдельные предложения. 
//Выведите каждое предложение на отдельной строке. 

//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//string[] mas = str.Split('.','!','?');
//foreach (string i in mas) Console.WriteLine(i);

//Задание 4. Разделение строки на числа: 
//Пользователь вводит строку, содержащую числа, разделенные 
//пробелами, например, "10 20 30 40". 
//Используя метод Split и пробел в качестве разделителя, разделите строку 
//на отдельные числа. 
//Преобразуйте каждое полученное значение в числовой тип данных 
//(например, int или double). 
//Выполните операции или выведите полученные числа по вашему 
//выбору. 

//using System.Threading.Channels;

//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//string[] mas = str.Split(' ');
//foreach (string strNumber in mas)
//{
//    bool isNumber = true;
//    for (int i = 0; i < strNumber.Length; i++)
//    {
//        if (!char.IsDigit(strNumber[i])&&strNumber[i]!=','&&strNumber[i] != '.') 
//        { 
//            isNumber = false;
//            break;
//        }
//    }
//    if (isNumber&&!strNumber.Contains('.')&&!strNumber.Contains(','))Console.WriteLine(int.Parse(strNumber));
//    else
//    if (isNumber && (strNumber.Contains('.') || strNumber.Contains(',')))
//    {
//        if (strNumber.Contains('.'))
//        {
//            string temp = strNumber.Replace('.', ',');
//            Console.WriteLine(double.Parse(temp));
//        }
//        else Console.WriteLine(double.Parse(strNumber));

//    }
//}
while(true)
Console.WriteLine(Console.ReadKey().Key);