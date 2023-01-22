// Задача 1: 

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


// Инструкция делаем через создание фукции InputIn 
int InputIn(string message)
{
    System.Console.WriteLine(message);
    string AString = Console.ReadLine();
    int a = Convert.ToInt32(AString);
    return a;
}

int a = InputIn("Введите первое число ");
int b = InputIn("Введите второе число ");
// Сравнить два числа
if(a>b)
{
    System.Console.Write($"число {a} - max  ");
    System.Console.Write($"число {b} - min  ");
}
else
{
    System.Console.Write($"число {b} - max  ");
    System.Console.Write($"число {a} - min  ");
}