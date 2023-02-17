// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());

switch(a)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    Console.WriteLine("Это будний день :(");
    break;
    case 6:
    case 7:
    Console.WriteLine("Выходнооой :)");
    break;
    default:
    Console.WriteLine("Такого дня недели не существует");
    break;

}
