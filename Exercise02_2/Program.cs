 // Задача 2: другой вариант написания
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите три числа через Enter > ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if(b>max)
{
    max = b;
}
if(c>max)
{
    max = c;
    System.Console.WriteLine($" max -> {max} ");
}
else
{
    System.Console.WriteLine($" max -> {max} ");
}
// Программа рабочая это решение мне  нравится больше что числа нужно заносить через Enter.
