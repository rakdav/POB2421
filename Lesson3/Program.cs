//Console.WriteLine("Как вас зовут?");
//string name=Console.ReadLine();
//Console.WriteLine("Сколько вам лет?");
//int age=int.Parse(Console.ReadLine());
//Console.WriteLine("Откуда вы?");
//string from=Console.ReadLine();
//Console.WriteLine("Кем вы работаете?");
//string work=Console.ReadLine();
//Console.WriteLine("Ваше увлечение:");
//string hobby=Console.ReadLine();
//Console.WriteLine($"Пользователь, {name}. Возраст {age} лет. Родом из {from}. Профессия:{work}." +
//    $"Увлечение:{hobby}");

//2
//const long INN = 123456789123;
//const string company = "Рога и копыта";

//Console.Write("Введите продукт:");
//string name1=Console.ReadLine();
//Console.Write("Введите количество:");
//int count1 =int.Parse(Console.ReadLine());
//Console.Write("Введите цену:");
//decimal price1 = int.Parse(Console.ReadLine());

//Console.Write("Введите продукт:");
//string name2 = Console.ReadLine();
//Console.Write("Введите количество:");
//int count2 = int.Parse(Console.ReadLine());
//Console.Write("Введите цену:");
//decimal price2 = int.Parse(Console.ReadLine());

//Console.Write("Введите продукт:");
//string name3 = Console.ReadLine();
//Console.Write("Введите количество:");
//int count3 = int.Parse(Console.ReadLine());
//Console.Write("Введите цену:");
//decimal price3 = int.Parse(Console.ReadLine());
//decimal sum=count1*price1+count2*price2 + count3*price3;
//Console.Title = "Чек ";
//Console.WriteLine(
//    $"--------------------------------\n" +
//    $"Организация: {company}\n" +
//    $"ИНН:{INN}\n" +
//    $"*********************************\n" +
//    $"{"N",-4}{"Название",-10}{"Цена",-6}{"Кол.",-6}{"Сумма",-6} р.\n" +
//    $"{1,-4}{name1,-10}{price1,-6}{count1,-6}{price1 * count1,-6} р.\n" +
//    $"{2,-4}{name2,-10}{price2,-6}{count1,-6}{price2 * count2,-6} р.\n" +
//    $"{3,-4}{name3,-10}{price3,-6}{count3,-6}{price3 * count3,-6} р.\n" +
//    $"{"Итог:",-26}{sum.ToString("c")}");


//Console.Write("Введите ваше фио:");
//string fio=Console.ReadLine();
//Console.Write("Введите дату в формате ГГГГ.ММ.ДД:");
//DateTime birthDay=DateTime.Parse(Console.ReadLine());
//int age=DateTime.Now.Year-birthDay.Year;
//Console.WriteLine($"Привет, {fio}. Ваш возраст {age} лет");

//Console.Write("Введите x1:");
//double x1 = double.Parse(Console.ReadLine());
//Console.Write("Введите x2:");
//double x2 = double.Parse(Console.ReadLine());
//double y = Math.Sqrt(x1 * x1 + x2 * x2);
//Console.WriteLine($"y={y:F2}");

//const double G = 6.67E-12;

Console.WriteLine("Введите секунды:");
int n=int.Parse(Console.ReadLine());
int hours = n / 3600;
int minutes = n % 3600 / 60;
int seconds = n % 60;

