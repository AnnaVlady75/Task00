﻿// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("введите координаты точки ");
Console.WriteLine("X : ");
int xc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y : ");
int yc = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xc, yc); // условие ? значение :иначе  значение
string result = quarter > 0
                ? $"Указанные координаты соответсвуют четверти {quarter}"
                :"Введены некорректные координаты";
Console.WriteLine(result);                

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}