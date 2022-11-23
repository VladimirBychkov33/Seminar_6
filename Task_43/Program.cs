//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//    y = k1 * x + b1,    y = k2 * x + b2;    значения b1, k1, b2 и k2 задаются пользователем.
//   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write($"Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write($"Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write($"Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write($"Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine();

double Intersection(double num1, double num2, double num3, double num4)
{
    double resY = 0;
    double resX = 0;
    resX = (b2 - b1) / (k1 - k2);
    resY = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    Console.Write($"Координаты точки пересечения равны ({resX} , {resY}) ");
    return resY;
}

Intersection(b1,b2,k1,k2);