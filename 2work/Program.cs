//По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (b * b == a)
{
    Console.WriteLine("Первое число являеться корнем второго");
}
else if (a * a == b)
{
    Console.WriteLine("Второе число являеться корнем первого");
}
else
{
    Console.WriteLine("Числа не являются корнями друг друга");
}