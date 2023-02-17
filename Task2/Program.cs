// See https://aka.ms/new-console-template for more information
int a = new Random().Next(99, 1000);
Console.WriteLine(a);
int hund = a / 100;
int unit = a % 10;
Console.WriteLine(hund*10 + unit);