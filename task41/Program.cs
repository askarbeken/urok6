// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
Console.Write($"Введите число {i + 1}: ");
string input = Console.ReadLine();
double num = Convert.ToDouble(input);
if (num > 0)
{
count++;
}
}
Console.WriteLine($"Количество чисел больше 0: {count}");
