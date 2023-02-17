// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите любое число: ");
string a = Console.ReadLine();
int length = a.Length;
if (length < 3)
Console.WriteLine("Третьего числа нет");
else
{
int b = Convert.ToInt32(a);
double hund = b % Math.Pow(10, length-2);
int ten = (int)(hund / Math.Pow(10, length-3));
Console.WriteLine(ten);
}
