//1
//Console.Write("Введите количество жителей в первом доме:");
//int home1=int.Parse(Console.ReadLine());
//Console.Write("Введите количество жителей во втором доме:");
//int home2 = int.Parse(Console.ReadLine());
//Console.Write("Введите количество жителей в третьем доме:");
//int home3 = int.Parse(Console.ReadLine());
//int sum = home1 + home2 + home3;
//Console.WriteLine("Cуммарное количество:"+sum);//конкатенация
//Console.WriteLine($"Cуммарное количество:{sum}");//интерполяция
//Console.WriteLine("Cуммарное количество:{0}",sum);//экстраполяция
//2
//const float PI = 3.14f;
//Console.Write("Введите радиус:");
//float R = float.Parse(Console.ReadLine());
//float S = PI * R * R;
//float L = 2 * PI * R;
//Console.WriteLine($"Площадь:{S:F2} Длина:{L:F2}");

//3
//const double K = 273.15;
//Console.Write("Введите температуру в цельсиях:");
//double t = double.Parse(Console.ReadLine());
//double T = t + K;
//double F = (9* t/5)+32;
//Console.WriteLine($"В Кельвинах:{T:F2}, в Фаренгейтах:{F:F2}");
Console.Title = "Чек";
Console.WriteLine("--------------------------------\n" +
    "*****************************");
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine($"{"N",-4}{"Название",-10}{"Цена",-6}{"Кол.",-6}{"Сумма",-6}");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"{1,-4}{"",-10}{"Цена",-6}{"Кол.",-6}{"Сумма",-6}\n");
