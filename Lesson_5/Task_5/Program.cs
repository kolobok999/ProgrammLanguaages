// Задача 5: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

using static Library.Library;

int[] ProductNumbers(int[] arr, int n)
{

    int[] newArray = new int[n];
    int length = arr.Length;
    for (int i = 0; i < length / 2; i++)
    {
        newArray[i] = arr[i] * (arr[length - 1 - i]);
    }
    if (length % 2 > 0)
        newArray[n - 1] = arr[n - 1];
    return newArray;
}

int[] array = new int[5];
int[] arrayProd = new int[array.Length];

WriteArray(array, 1, 10);
if (array.Length % 2 != 0)
    arrayProd = ProductNumbers(array, array.Length / 2 + 1);
else
    arrayProd = ProductNumbers(array, array.Length / 2);

System.Console.WriteLine($"[ {PrintArray(array)}] -> [ {PrintArray(arrayProd)}]");
