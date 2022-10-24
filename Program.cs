﻿// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк");
int linesVol = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = int.Parse(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);