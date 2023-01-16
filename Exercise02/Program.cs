// Задача 2: 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите три числа через Enter > ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if(a>b)
if(a>c)
{
    System.Console.WriteLine($" max -> {a} ");
}
if(b>c)
if(b>a)
{
    System.Console.WriteLine($" max -> {b} ");
}
if(c>b)
if(c>a)
{
    System.Console.WriteLine($" max -> {c} ");
}
// Программа рабочая но мне не нравится что числа нужно заносить через дробь. Как ввести значение индекса?
