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

//Console.Write("Введите рубли:");
//int n=int.Parse(Console.ReadLine());
//if (n % 100 >= 11 && n % 100 <= 14)
//    Console.WriteLine(n + " рублей");
//else
//    switch (n % 10)
//    {
//        case 1: Console.WriteLine(n + " рубль");break;
//        case 2:case 3:case 4: Console.WriteLine(n+" рубля");break;
//        default: Console.WriteLine(n + " рублей"); break;
//    }

//Random random = new Random();
//Console.Write("Меню:\n" +
//    "1 - сгенерировать целое число\n" +
//    "2 - сгенерировать вещественное число\n" +
//    "3 - сгенерировать число в диапазоне\n");
//int n=int.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:
//        {
//            Console.Write("Введите верхнюю границу числа:");
//            int m=int.Parse(Console.ReadLine());
//            Console.WriteLine(random.Next(m+1));
//        }
//        break;
//    case 2:
//        {
//            Console.Write("Введите верхнюю границу числа:");
//            int m = int.Parse(Console.ReadLine());
//            Console.WriteLine($"{random.NextDouble()*m:F2}");
//        }
//        break;
//    case 3:
//        {
//            Console.Write("Введите нижнюю границу:");
//            int min = int.Parse(Console.ReadLine());
//            Console.Write("Введите верхнюю границу:");
//            int max = int.Parse(Console.ReadLine());
//            if(min > max)
//            {
//                int temp = min;
//                min = max;
//                max = temp;
//            }
//            Console.WriteLine(random.Next(min,max+1));
//        }
//        break;
//}

//Random random = new Random();
//Console.Write("Введите первый элемент:");
//string a=Console.ReadLine();
//Console.Write("Введите второй элемент:");
//string b = Console.ReadLine();
//Console.Write("Введите третий элемент:");
//string c = Console.ReadLine();

//switch (random.Next(1,4))
//{
//    case 1: Console.Write(a); break;
//    case 2: Console.Write(b); break;
//    case 3: Console.Write(c); break;
//}

//Random random = new Random();
//Console.Write("1 - доллар\n" +
//    "2 - евро\n" +
//    "3 - юань\n");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Введите количество валюты:");
//decimal money=decimal.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:
//        {
//            Console.Write("Введите курс доллара:");
//            decimal kurs = decimal.Parse(Console.ReadLine());
//            Console.WriteLine($"{money} долларов {kurs * money} рублей");
//        }
//        break;
//    case 2:
//        {
//            Console.Write("Введите курс евро:");
//            decimal kurs = decimal.Parse(Console.ReadLine());
//            Console.WriteLine($"{money} евро {kurs * money} рублей");
//        }
//        break;
//    case 3:
//        {
//            Console.Write("Введите курс юаня:");
//            decimal kurs = decimal.Parse(Console.ReadLine());
//            Console.WriteLine($"{money} юаней {kurs * money} рублей");
//        }
//        break;
//}

//Console.Write("Выберите: 1 - камень, 2 - ножницы, 3 - бумага:");
//int n=int.Parse(Console.ReadLine());
//Random random = new Random();
//int m=random.Next(1,4);
//switch (n)
//{
//    case 1: 
//        {
//            Console.Write("Камень - ");
//            if (m == 1) Console.WriteLine("Камень. Ничья");
//            else if (m == 2) Console.WriteLine("Ножницы. Победа");
//            else Console.WriteLine("Бумага. Поражение");
//        } 
//        break;
//    case 2:
//        {
//            Console.Write("Ножницы - ");
//            if (m == 1) Console.WriteLine("Камень. Поражение");
//            else if (m == 2) Console.WriteLine("Ножницы. Ничья");
//            else Console.WriteLine("Бумага. Победа");
//        }
//        break;
//    case 3:
//        {
//            Console.Write("Бумага - ");
//            if (m == 1) Console.WriteLine("Камень. Победа");
//            else if (m == 2) Console.WriteLine("Ножницы. Поражение");
//            else Console.WriteLine("Бумага. Ничья");
//        }
//        break;
//}

//Random random = new Random();
//int i = 1;
//int count = 0;
//while (i<=10) 
//{
//    int n = random.Next(10);
//    int m = random.Next(10);
//    switch (random.Next(1, 5))
//    {
//        case 1:
//            {
//                Console.WriteLine($"{n}+{m}");
//                Console.Write("Введите ответ:");
//                int s = int.Parse(Console.ReadLine());
//                if (n + m == s) count++;
//            }
//            break;
//        case 2:
//            {
//                Console.WriteLine($"{n}-{m}");
//                Console.Write("Введите ответ:");
//                int s = int.Parse(Console.ReadLine());
//                if (n - m == s) count++;
//            }
//            break;
//        case 3:
//            {
//                Console.WriteLine($"{n}*{m}");
//                Console.Write("Введите ответ:");
//                int s = int.Parse(Console.ReadLine());
//                if (n * m == s) count++;
//            }
//            break;
//        case 4:
//            {
//                Console.WriteLine($"{n}/{m}");
//                Console.Write("Введите ответ:");
//                int s = int.Parse(Console.ReadLine());
//                if (n / m == s) count++;
//            }
//            break;
//    }
//    i++;
//}
//Console.WriteLine(count);

//Console.Write("Введите ваш возраст:");
//int age=int.Parse(Console.ReadLine());
//if (age < 18) Console.WriteLine("Вы слишкоммолоды для участия в выборах");
//else if (age >= 18 && age <= 35) Console.WriteLine("Вы можете участвовать в выборах в качестве депутата");
//else if (age >= 36 && age <= 65) Console.WriteLine("Вы можете участвовать в выборах в качестве кандидата в президенты");
//else Console.WriteLine("Ваш возраст слишком велик для участия в выборах");

//Console.WriteLine("Кандидаты в президенты солнечного города:\r\n● Незнайка\r\n● Лунтик\r\n● Карлсон\r\n● Дядя Фёдор");
//Console.Write("За кого бы вы голосовали:");
//string name=Console.ReadLine();
//if (name == "Незнайка") Console.WriteLine("А у тебя в животе арбуз вырастет!!!");

using System.Threading.Channels;

Random random = new Random();
int n=random.Next(13);
switch (n)
{
    case 1:
        {
            Console.WriteLine("Январь");
        }
        break;
    case 2:
        {
            Console.WriteLine("Февраль");
        }
        break;
    case 3:
        {
            Console.WriteLine("Март");
        }
        break;
    case 4:
        {
            Console.WriteLine("Апрель");
        }
        break;
    case 5:
        {
            Console.WriteLine("Май");
        }
        break;
    case 6:
        {
            Console.WriteLine("Июнь");
        }
        break;
    case 7:
        {
            Console.WriteLine("Июль");
        }
        break;
    case 8:
        {
            Console.WriteLine("Август");
        }
        break;
    case 9:
        {
            Console.WriteLine("Сентябрь");
        }
        break;
    case 10:
        {
            Console.WriteLine("Октябрь");
        }
        break;
    case 11:
        {
            Console.WriteLine("Ноябрь");
        }
        break;
    case 12:
        {
            Console.WriteLine("Декабрь");
        }
        break;
}
Console.Write("Введите количество дней:");
int m = int.Parse(Console.ReadLine());
if (n == 1 || n == 3 || n == 5 || n == 7 || n == 8 || n == 10 || n == 12)
    if (m == 31) Console.WriteLine("Победа");
    else Console.WriteLine($"Поражение! В этом месяце 31 день");
else if (n == 4 || n == 6 || n == 9 || n == 11) 
        if(m==30) Console.WriteLine("Победа");
        else Console.WriteLine($"Поражение! В этом месяце 30 дней");
else if(n==2&&(m==28||m==29)) Console.WriteLine("Победа");
     else Console.WriteLine($"Поражение! В этом месяце 28 или 29 дней");
