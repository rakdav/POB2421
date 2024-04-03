//Console.WriteLine(9 & 6);
//Console.WriteLine(16 & 7);
//Console.WriteLine(8 & 14);
//Console.WriteLine(5&22);

//Console.WriteLine(5 | 9);
//Console.WriteLine(8 | 19);
//Console.WriteLine(3 | 7);
//Console.WriteLine(22|46);

//Console.WriteLine(9^6);
//Console.WriteLine(15^6);
//Console.Write("Введите целое число:");
//int n=int.Parse(Console.ReadLine());
//Console.Write("Введите ключ:");
//int key=int.Parse(Console.ReadLine());
//int crypt = n ^ key;
//Console.WriteLine($"Зашифрованное сообщение:{crypt}");
//int encrypt=crypt^key;
//Console.WriteLine($"Расшифрованное сообщение:{encrypt}");

//Console.WriteLine(~8);
//Console.WriteLine(~256854);
//Console.WriteLine(~2146569854);

//Console.WriteLine(894257>>1);
//Console.WriteLine(894257<<1);
//Console.WriteLine(23649587 >> 1);
//Console.WriteLine(23649587 << 1);

//int x = 18;
//x += 259;
//Console.WriteLine(x);

//x = 948;
//x += 259;
//Console.WriteLine(x);

//x = 8246;
//x += 259;
//Console.WriteLine(x);

//x = 297854;
//x += 259;
//Console.WriteLine(x);

Console.Write("Введите первое число:");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine(x&y);
Console.WriteLine(x|y);
Console.WriteLine(~x);
Console.WriteLine(x^y);
Console.WriteLine(x>>y);
Console.WriteLine(x<<y);