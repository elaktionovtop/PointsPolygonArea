/*
C# for Grandchildren: educational console application
*/

using System.Drawing;

using static ConsoleLibrary.ConsoleApp;
using static ConsoleLibrary.ConsoleIO;
using static System.Console;

WriteAppTitle("Программа...");
Run(Action);
PromptExitApp();

void Action()
{
    int n = ReadInteger("Введите количество точек: ");
    PointF[] points = new PointF[n];
    for (int i = 0; i < n; i++)
    {
        points[i] = ReadPointF($"Введите координаты точки {i}");
    }
    double area = 0;
    for(int i = 2; i < n; i++)
    {
        area += getTriangleArea(getDistance(points[0], points[i - 1]), getDistance(points[0], points[i]), getDistance(points[i - 1], points[i]));
    }

    WriteLine($"area = {area:F2}");

}

double getDistance(PointF point1, PointF point2)
{
    return Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) +
        (point2.Y - point1.Y) * (point2.Y - point1.Y));
}

double getTriangleArea(double a, double b, double c)
{
    double p = (a + b + c) / 2;
    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
}

