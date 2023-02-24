// Задача 4: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
using static Library.Library;

int ElementCounter(int[] arr, int a, int b)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if ((arr[i] >= a) && (arr[i]) <= b) count++;
    return count;
}

void PrintResult(int[] arr, int n)
{
    System.Console.WriteLine($"[ {PrintArray(arr)}] -> {n}");
}

int[] array = new int[123];
WriteArray(array);

int elementQuantity = ElementCounter(array, 10, 99);

PrintResult(array, elementQuantity);