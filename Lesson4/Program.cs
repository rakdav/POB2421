//int x = 6;
//Console.WriteLine(x++);
//Console.WriteLine(x);
//Console.WriteLine(++x);
//Console.WriteLine(x--);
//Console.WriteLine(x);
//Console.WriteLine(--x);
//int x = 0;
//Console.WriteLine(x);
//x += 46;
//Console.WriteLine(x);
//x += 12;
//Console.WriteLine(x);
//x += 4;
//Console.WriteLine(x);
//x += 8;
//Console.WriteLine(x);
//x += 15;
//Console.WriteLine(x);
//int children = 28;
//int mother = 24;
//int father = 18;
//Console.WriteLine(mother+father-children);

//decimal summa = 56000;
//decimal part = summa / 8;
//Console.WriteLine($"{(part*5):C}:{part*2}:{part*1}");

//double s = 240;
//double v1 = 3;
//double v2 = 2;
//double t2 = (s / v2);
//double t1 = (s / v1);
//Console.WriteLine(t2-t1);

//Console.Write("Введите число:");
//int y=int.Parse(Console.ReadLine());
//Console.WriteLine(y - y / 10 % 10 * 10);

//Console.Write("Введите четырехзначное число:");
//int y = int.Parse(Console.ReadLine());
//int a = y % 10;
//int b = y % 100/10;
//int c = y % 1000 / 100;
//int d = y / 1000;
//int s = a + b + c + d;
//Console.WriteLine(s);
//int p=a*b*c*d;
//Console.WriteLine(p);

//Console.Write("Введите количество монет:");
//int n=int.Parse(Console.ReadLine());
//int bread = 30;
//int butter = 100;
//int milk = 40;
//Console.WriteLine($"Xлеб - {bread}");
//Console.WriteLine($"Масло - {butter}");
//Console.WriteLine($"Молоко - {milk}");
//Console.Write("Введите количество хлеба:");
//int breadCount=int.Parse(Console.ReadLine());
//Console.Write("Введите количество масла:");
//int butterCount = int.Parse(Console.ReadLine());
//Console.Write("Введите количество молока:");
//int milkCount = int.Parse(Console.ReadLine());
//int priceBread = bread * breadCount;
//int priceButter= butter * butterCount;
//int priceMilk= milk * milkCount;
//int total=priceBread + priceButter+priceMilk;
//Console.WriteLine($"Хлеб   - {breadCount} шт {priceBread} р.");
//Console.WriteLine($"Масло  - {butterCount} шт {priceButter} р.");
//Console.WriteLine($"Молоко - {milkCount} шт {priceMilk} р.");
//Console.WriteLine($"Итого:{total}");
//Console.WriteLine($"Сдача:{n-total}");

Console.Write("Введите день года:");
int k=int.Parse(Console.ReadLine());
Console.Write("Введите день недели приходящийся на 1 января(1-пн,2-вт и т.д.:");
int d=int.Parse(Console.ReadLine());
Console.WriteLine(k % 7 + d - 1);


