﻿// Задача 3: 
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите числo > ");
int a = Convert.ToInt32(Console.ReadLine());

if(a%2 == 0)
{
    System.Console.WriteLine($" Число {a} - четное ");
}
else
{
    System.Console.WriteLine($" Число {a} - нечетное ");
}

