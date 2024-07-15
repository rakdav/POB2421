DayOfWeek day = DayOfWeek.Sunday;
Console.WriteLine(NextDay(DayOfWeek.Monday));
DayOfWeek NextDay(DayOfWeek day)
{
    return (day < DayOfWeek.Sunday) ? ++day : DayOfWeek.Monday;
}

Console.Write("Введите чтсло от 1 до 5:");
int n;
int.TryParse(Console.ReadLine()!, out n);
if (n > 0 && n < 6)
{
    CommodityType commodity = (CommodityType)Enum.GetValues(typeof(CommodityType)).GetValue(n - 1)!;
    TransportType transport = TransportType.Semitrailer;
    switch (commodity)
    {
        case CommodityType.Frozenfood:
            transport = TransportType.Refregirator;
            break;
        case CommodityType.Food:
            transport = TransportType.Semitrailer;
            break;
        case CommodityType.DomesticChimestry:
            transport = TransportType.Coupling;
            break;
        case CommodityType.BuildingMaterials:
            transport = TransportType.OpenSideTruck;
            break;
        case CommodityType.Petrol:
            transport = TransportType.FuelTrack;
            break;
    }
    Console.WriteLine($"Для товара - {commodity} необходим транспорт {transport}");
}
else
{
    Console.WriteLine("Ощибка ввода");
}

//CompareTo - сравнивает текущий экземпляр с заданным объектом, и возвращает значение: <0 - если значение текущего экземпляра меньше заданного, 0 - если равны, >0 - если значение текущего экземпляра больше заданного

//GetName - выводит имя константы в указанном перечислении, имеющем заданное значение
//GetNames - выводит массив имен констант в перечмслении
//GetValues - выводит массив значений констант в указанном перечислении
//IsDefined - возвращает признак наличия константы с указанным значением в заданном перечислении.
//Parse - преобразует строковое значение в перечисляемый тип
//ToString() - преобразует в строку

Console.Write("Введите название планеты:");
string name = Console.ReadLine()!;
if (!Enum.IsDefined(typeof(DistanceSun), name))
{
    Console.WriteLine($"Значения {name} нет в перечислении");
}

foreach(DistanceSun item in Enum.GetValues(typeof(DistanceSun)))
{
    Console.WriteLine("{0,-10} {1,-10} {2,-10}",
        Enum.Format(typeof(DistanceSun),item,"G"),
        Enum.Format(typeof(DistanceSun),item,"D"),
        Enum.Format(typeof(DistanceSun),item,"X"));
}
foreach(string str in Enum.GetNames(typeof(DistanceSun)))
{
    Console.WriteLine(str);
}
enum EnumName { elem1,elem2,elem3,elem4}
enum DayOfWeek { Monday,Tuesday,Wednesday,Thurday,Friday,Saturday,Sunday}
enum Discount { Default,Incentive=2,Patron=5,VIP=15}
enum CommodityType { Frozenfood, Food, DomesticChimestry,BuildingMaterials,Petrol}
enum TransportType
{
    Semitrailer, Coupling, Refregirator, OpenSideTruck, FuelTrack
}

 enum DistanceSun : ulong
{
    Sun=0,
    Mercury=57900000,
    Venus=108200000,
    Earth=149600000,
    Mars=227900000,
    Jupiter=778300000,
    Saturn=1427000000,
    Uran=2870000000,
    Neptune=4496000000,
    Pluto=5946000000
}
