// See https://aka.ms/new-console-template for more information
using CalciApp;

Calc calc = new Calc();
Console.WriteLine("** Add Call **");
calc.Add(12,45);
Console.WriteLine("** Multiply Call **");
calc.Mul(10.5,12.45);
Console.WriteLine("** Div Call **");
calc.Div(28,14);
Console.WriteLine("** Sub Call **");
calc.Sub(40,15);
Console.WriteLine("** Avg Call **");
calc.Avg(50,25);