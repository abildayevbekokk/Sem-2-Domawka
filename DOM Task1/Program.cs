// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int hund = a % 100;
int ten = hund / 10;
if (a>99 && a<1000) 
Console.WriteLine(ten);
else 
Console.WriteLine("Вот это поворот, все наоборот");
