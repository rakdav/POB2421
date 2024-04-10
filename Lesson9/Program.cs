//Console.Write("Введите название дня недели:");
//int n=int.Parse(Console.ReadLine());
//if (n == 1) Console.WriteLine("Mon");
//else if (n == 2) Console.WriteLine("Thu");
//     else if (n == 3) Console.WriteLine("Wen");
//          else if (n == 4) Console.WriteLine("The");
//               else if (n == 5) Console.WriteLine("Fri");
//                    else if (n == 6) Console.WriteLine("Sat");
//                         else if (n == 7) Console.WriteLine("Sun");
//                              else Console.WriteLine("Нет такого дня недели");

//switch (n)
//{
//    case 1: Console.WriteLine("Mon");break;
//    case 2: Console.WriteLine("Thu");break;
//    case 3: Console.WriteLine("Wen");break;
//    case 4: Console.WriteLine("The");break;
//    case 5: Console.WriteLine("Fri");break;
//    case 6: Console.WriteLine("Sat");break;
//    case 7: Console.WriteLine("Sun");break;
//    default: Console.WriteLine("Нет такого дня недели");break;
//}

//Console.Write("Введите номер месяца:");
//int n = int.Parse(Console.ReadLine());
//switch (n)
//{
//    case 12:case 1:case 2:Console.WriteLine("Зима");break;
//    case 3: case 4: case 5: Console.WriteLine("Весна"); break;
//    case 6: case 7: case 8: Console.WriteLine("Лето"); break;
//    case 9: case 10: case 11: Console.WriteLine("Осень"); break;
//    default: Console.WriteLine("Нет такого месяца"); break;
//}

//Console.Write("Введите масть:");
//int n=int.Parse(Console.ReadLine());
//Console.Write("Введите номинал:");
//int m = int.Parse(Console.ReadLine());
//switch (m)
//{
//    case 6:Console.Write("шесть ");break;
//    case 7: Console.Write("семь "); break;
//    case 8: Console.Write("восемь "); break;
//    case 9: Console.Write("девять "); break;
//    case 10: Console.Write("десять "); break;
//    case 11: Console.Write("валет "); break;
//    case 12: Console.Write("дама "); break;
//    case 13: Console.Write("король "); break;
//    case 14: Console.Write("туз "); break;
//}
//switch (n)
//{
//    case 1:Console.WriteLine("крести");break;
//    case 2:Console.WriteLine("бубны");break;
//    case 3: Console.WriteLine("пики"); break;
//    case 4: Console.WriteLine("черви"); break;
//}

Console.Write("Введите рубли:");
int n=int.Parse(Console.ReadLine());
if (n % 100 >= 11 && n % 100 <= 14)
    Console.WriteLine(n + " рублей");
else
    switch (n % 10)
    {
        case 1: Console.WriteLine(n + " рубль");break;
        case 2:case 3:case 4: Console.WriteLine(n+" рубля");break;
        default: Console.WriteLine(n + " рублей"); break;
    }