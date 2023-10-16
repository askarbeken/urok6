// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double k1, b1, k2, b2;
Console.Write("Введите значение k1: ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2 && b1 == b2)
{
Console.WriteLine("Имеют множество общих точек.");
}
else if (k1 == k2)
{
Console.WriteLine("Прямые параллельны и не имеют точки пересечения.");
}
else
{
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
x = Math.Round(x, 2);
y = Math.Round(y, 2);
Console.WriteLine("Точка пересечения прямых: x = " + x + ", y = " + y);
}