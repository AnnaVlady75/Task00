﻿// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число N: ");
int number = int.Parse(Console.ReadLine());
if (number > 0) NaturalNumbers(number);
else Console.WriteLine($"{number} - НЕ натуральное, повторите попытку ");

void NaturalNumbers(int num)
{
    if (num == 0) return;
    if (num != 1)
    {
        Console.Write($"{num}, ");
        NaturalNumbers(num - 1);
    }
    else
        Console.Write($"{num} ");
}