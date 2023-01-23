// Задача 4: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
//!!! Мое решение!!
// System.Console.WriteLine("Введите число > ");

// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 2; i <= n; i+=2)
// if (i % 2 == 0)
// Console.Write($"{i} ");

//НЕ Мое решение!!
// System.Console.WriteLine("Введите число > ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count =2;// вместо i введен другой индекс
// string Numbers = "";
// string separator = "";
// while (count <= n)
// {
//     if(count>2)
//     {
//         Numbers = Numbers + separator + count;
//     }
//     count+=2;
// }

// System.Console.WriteLine($"четные числа: {Numbers} ");


//!!! Мое решение №2!!
System.Console.WriteLine("Введите число > ");

int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
while(i <= n)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i+=2;
}

