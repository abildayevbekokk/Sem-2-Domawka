// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
Console.WriteLine($"Второе число кратно первому, и меньше ровно в {a/b} раза");
else
Console.WriteLine($"Число не кратно и остаток составляет {a%b}");

