﻿// 14. Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно одновременно
// 7 и 23. 14 -> нет 46 -> нет 161 -> да


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (Multiplicity(number)) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно");

bool Multiplicity(int num)
{
	int number1 = 7;
	int number2 = 23;
	return num % number1 == 0 && num % number2 == 0;
}