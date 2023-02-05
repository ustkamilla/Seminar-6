/*
Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int InputInt(string message)
{
    System.Console.WriteLine($"{message}");
    return int.Parse(Console.ReadLine()!);
}

(double, double) IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

double b1 = InputInt("Введите значение b1");
double k1 = InputInt("Введите значение k1");
double b2 = InputInt("Введите значение b2");
double k2 = InputInt("Введите значение k2");

if (k1 != k2)
{
    (double x, double y) = IntersectionPoint(b1,k1,b2,k2);
    Console.WriteLine($"Прямые пересекаются в точке ({x}, {y}).");
}
else
{
    System.Console.WriteLine("Прямые не пересекаются или совпадают.");
}

