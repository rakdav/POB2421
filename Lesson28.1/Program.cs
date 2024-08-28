using Lesson28._1;
using Lesson28._2;
using System;

Console.Write("Введите размер массива:");
int n;
int.TryParse(Console.ReadLine(), out n);
ArrayClass array = new ArrayClass(n);
array.Print();
Console.WriteLine($"Сумма:{array.Sum():F2}");
Console.WriteLine($"Максимум:{array.Max():F2}");
Console.WriteLine($"Минимум:{array.Min():F2}");
array.Sort();
array.Print();
Console.WriteLine($"Сумма:{ClassArray.Sum(array.getMas()):F2}");
