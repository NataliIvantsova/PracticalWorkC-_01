// Задача 1: 

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Инструкция
//1 Запросить у пользователя первое число и сохранить её ы переменную А

System.Console.WriteLine("Введите первое число ");
// Перевести число в тип данных int
int a = Convert.ToInt32(Console.ReadLine());
//2 Запросить у пользователя первое число и сохранить её ы переменную А
System.Console.WriteLine("Введите второе число ");
// Перевести число в тип данных int
int b = Convert.ToInt32(Console.ReadLine());
// Сравнить два числа
if(a>b)
{
    System.Console.Write($"число {a} > max  ");
    System.Console.Write($"число {b} > min  ");
}
else
{
    System.Console.Write($"число {b} > max  ");
    System.Console.Write($"число {a} > min  ");
}