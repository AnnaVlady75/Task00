﻿// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите позицию строки: ");
int rows = Convert.ToInt32(Console.ReadLine()); ;
Console.WriteLine("Введите позицию столбца: ");
int columns = Convert.ToInt32(Console.ReadLine()); ;

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
if (rows < 0 || rows > array2d.GetLength(0)
     || columns < 0 || columns > array2d.GetLength(1))
    Console.WriteLine("Такого элемента в массиве нет");
else Console.WriteLine($"Значение этого элемента -> {array2d[rows,columns]}");


