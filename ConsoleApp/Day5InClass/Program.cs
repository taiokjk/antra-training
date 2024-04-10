// See https://aka.ms/new-console-template for more information
using Day5InClass;
using System.Text;

Console.WriteLine("Hello, World!");

int? a = null;
Console.WriteLine($"Hey try this: {a}");

StringBuilder sb = new StringBuilder("test");
sb[0] = 's';

Console.WriteLine(sb);

DaysOfWeek today = DaysOfWeek.Monday;
Console.WriteLine(today);

a = 10;
int b = 20;
ParamsPassing paramsPassing = new ParamsPassing();
paramsPassing.PassByValue(a.Value, b);
Console.WriteLine($"outside: a={a}, b={b}");

paramsPassing.PassByRef(ref a, ref b);
Console.WriteLine($"outside: a={a}, b={b}");

a = 10;
paramsPassing.AreaOfCirle(a.Value);

string msg;
Console.WriteLine(paramsPassing.isAuthentic("root", "linux", out msg) + " " + msg);
Console.WriteLine(paramsPassing.isAuthentic("root", "notlinux", out msg) + " " + msg);

Console.WriteLine(paramsPassing.AddNumbers(10, 20, 30, 40));
//paramsPassing.AddTwoNumbers(10, 20);