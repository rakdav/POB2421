using Lesson29._3;

Console.Write("Введите размер массива:");
int n;
int.TryParse(Console.ReadLine()!, out n);
MasGenerator masGen = new MasGenerator(n);
masGen.IntGenerator(1, 100);
masGen.StringGenerator(10);
masGen.BoolGenarator();
