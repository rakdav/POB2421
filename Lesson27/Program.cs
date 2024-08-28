using Lesson27;

//Telephone telephone1 = new Telephone();
//Console.WriteLine(telephone1.getDaySay());
//Console.WriteLine(telephone1.getTimeSay());
//Console.WriteLine(telephone1.getCoastSay());

//Telephone telephone2 = new Telephone(6,10,1.2);
//Console.WriteLine(telephone2.getDaySay());
//Console.WriteLine(telephone2.getTimeSay());
//Console.WriteLine(telephone2.getCoastSay());
//telephone2.setCoastSay(2.3);
//Console.WriteLine(telephone2.getCoastSay());
//Console.WriteLine(telephone2.getTotal());
Console.Write("Введите первое число:");
double x;
double.TryParse(Console.ReadLine(), out x);
Console.Write("Введите второе число:");
double y;
double.TryParse(Console.ReadLine(), out y);
Calculator calculator = new Calculator();
char op;
Console.Write("Введите операцию:");
char.TryParse(Console.ReadLine(), out op);
switch (op)
{
    case '+': Console.WriteLine(calculator.Add(x,y)); break;
    case '-': Console.WriteLine(calculator.Sub(x, y)); break;
    case '*': Console.WriteLine(calculator.Mult(x, y)); break;
    case '/':
        try
        {
            Console.WriteLine(calculator.Div(x, y)); 
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;
}



