// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Выберите размерность пространства:");
Console.WriteLine("2D - введите '2'");
Console.WriteLine("3D - введите '3'");
Console.Write("Ваш выбор: ");
int D = int.Parse(Console.ReadLine()!);
Console.WriteLine("");
int X1 = 0;
int Y1 = 0;
int Z1 = 0;
int X2 = 0;
int Y2 = 0;
int Z2 = 0;

if (D == 2)
{
    Console.WriteLine("Введите координаты первой точки: ");
    Console.Write("X1 = ");
    X1 = int.Parse(Console.ReadLine()!);
    Console.Write("Y1 = ");
    Y1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите координаты второй точки: ");
    Console.Write("X2 = ");
    X2 = int.Parse(Console.ReadLine()!);
    Console.Write("Y2 = ");
    Y2 = int.Parse(Console.ReadLine()!);
    
    double rast = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
    Console.Write("Расстояние = " + rast);
}

if (D == 3)
{
    Console.WriteLine("Введите координаты первой точки: ");
    Console.Write("X1 = ");
    X1 = int.Parse(Console.ReadLine()!);
    Console.Write("Y1 = ");
    Y1 = int.Parse(Console.ReadLine()!);
    Console.Write("Z1 = ");
    Z1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите координаты второй точки: ");
    Console.Write("X2 = ");
    X2 = int.Parse(Console.ReadLine()!);
    Console.Write("Y2 = ");
    Y2 = int.Parse(Console.ReadLine()!);
    Console.Write("Z2 = ");
    Z2 = int.Parse(Console.ReadLine()!);

    double rast = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
    Console.Write("Расстояние = " + rast);
}