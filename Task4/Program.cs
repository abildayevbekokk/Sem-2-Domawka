// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23) //if (a % 161 == 0)
Console.WriteLine("Число имеет в делителях 7 и 23");
