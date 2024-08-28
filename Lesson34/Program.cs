using Lesson34;

//Console.Write("Введите фио:");
//string fio=Console.ReadLine()!;
//Console.Write("Введите возраст:");
//int age;
//int.TryParse(Console.ReadLine()!,out age);
//Console.Write("Введите зарплату:");
//double salary;
//double.TryParse(Console.ReadLine()!, out salary);

//Employee employee1=new Employee() { Age = age,Name=fio,Salary=salary };
//Employee.count++;
//Console.WriteLine(employee1.Name+" "+employee1.Age+" "+
//    employee1.Salary+" "+Employee.count);

//Employee employee2 = new Employee() { Age = age, Name = fio, Salary = salary };
//Employee.count++;
//Console.WriteLine(employee1.Name + " " + employee2.Age + " " +
//    employee2.Salary + " " + Employee.count);

Building building = new Building();
// Ввод параметров постройки
building.Type = "Двухэтажный коттедж";
building.FloorHeight = 3.0;
building.RoofHeight = 1.0;
building.Length = 10.0;
building.Width = 8.0;
building.FloorCount = 2;
building.WindowCount = 5;
building.RoomCount = 10;

// Расчет и вывод характеристик постройки
Console.WriteLine($"Высота здания: {building.CalculateBuildingHeight()} м.");
Console.WriteLine($"Площадь здания: {building.CalculateBuildingArea()} кв.м.");
Console.WriteLine($"Общее количество проемов: {building.CalculateTotalOpenings()}");

