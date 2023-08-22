// See https://aka.ms/new-console-template for more information
int x=10, y=5;
string a="abcd", b="efgh";

Console.WriteLine(a+b);

Console.WriteLine((x + y) / x);

x++;
y--;
Console.WriteLine(x);
Console.WriteLine(y);

a += b;
Console.WriteLine(a);

Console.WriteLine(x > y && y >= 5);
Console.WriteLine(x > y || y >= 5);

string str = null;
Console.WriteLine(str ?? "unknown");
// if str == null, disply str. otherwise display "unknown"
// similar to if (str == null) { str = x }
str ??= "new str";
Console.WriteLine(str);