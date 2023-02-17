// See https://aka.ms/new-console-template for more information
int a = new Random().Next(10, 100);
Console.WriteLine(a);
int unit = a % 10;
int ten = a / 10;
if (unit > ten)
Console.WriteLine(unit);
else if (unit < ten)
Console.WriteLine(ten);
else 
Console.WriteLine("Два числа равны ващет");
