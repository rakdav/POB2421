﻿//float d = 4506667f;
//int i = (int)d;
//Console.WriteLine(i);
//Console.WriteLine((double)5/9);
//int x = int.Parse(Console.ReadLine());
//int y=Convert.ToInt32(Console.ReadLine());
//string myName = "Иван\nИванов";
//Console.WriteLine(myName);
//string myString = "284"; 
//Console.WriteLine(int.Parse(myString));
//using System.Diagnostics;

//byte bt=byte.Parse(Console.ReadLine());
//long freq = Stopwatch.Frequency;
//Stopwatch stopwatch = new Stopwatch();
//stopwatch.Start();
////int integer = (int)bt;
//double l = (double)bt;
//stopwatch.Stop();
//decimal sec=(decimal)stopwatch.ElapsedTicks/freq;
//Console.WriteLine($"bt = {bt} \r\n Частота таймера"+ $"{freq} такт/с \r\n Время в тактах {stopwatch.ElapsedTicks} \r\n Время в секундах "+ $"{sec}");
//Console.WriteLine(l.ToString());
//Console.WriteLine($"{Math.PI:F2}");
//Console.WriteLine($"{Math.E:F1}");
//Console.WriteLine(Math.Sin(60*Math.PI/180));
using System.Threading.Channels;

string number = "28";
byte b=byte.Parse(number);
nint ni = (nint)b;
int i = (int)ni;
Console.WriteLine(i.GetType());