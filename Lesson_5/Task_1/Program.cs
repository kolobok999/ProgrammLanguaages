// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

using static Task_1.Library;

int FindPositiveSum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            result += arr[i];
        }
    }
    return result;
}

int FindNegativeSum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            result += arr[i];
        }
    }
    return result;
}

int[] array = new int[12];
WriteArray(array, -9, 10);


System.Console.WriteLine($" [{PrintArray(array)}] сумма положительных чисел равна {FindPositiveSum(array)}, сумма отрицательных равна - {FindNegativeSum(array)}");

