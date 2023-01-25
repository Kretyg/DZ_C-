// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите 1 из 4 четвертей: ");
int quarterNum = int.Parse(Console.ReadLine()!);

if (quarterNum == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (quarterNum == 2) 
{ 
    Console.WriteLine("x < 0, y > 0");
}
else if (quarterNum == 3) 
{
    Console.WriteLine("x < 0, y < 0");
}
else 
{
    Console.WriteLine("x > 0, y < 0");
}
