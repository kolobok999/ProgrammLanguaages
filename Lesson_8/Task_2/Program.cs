// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
using static Library.Library;

int[,] SwapStrings(int[,] matrix)
{
    int row = matrix.GetLength(0);

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int[] pair = { 0, j };
        SwapMatrix(matrix, new int[] { 0, j }, new int[] { row - 1, j });
    }

    return matrix;
}


int[,] matrix = new int[4, 3];

matrix = FillMatrix(matrix, 0, 20);
PrintMatrix(matrix);

matrix = SwapStrings(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);

// https://us04web.zoom.us/j/77453872895?pwd=9mYqdZhom083KnaDbYqBAQYHXVsMq1.1