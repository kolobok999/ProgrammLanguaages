// Задача 3: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

using static Task_3.Library;

bool FindNumber(int[] arr, int n)
{
    bool isFindNumber = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == n)
        {
            isFindNumber = true;
            break;
        }
    }
    return isFindNumber;
}

void PrintResult(int n, int[] arr, string str)
{
    System.Console.WriteLine($"{n}; массив [ {PrintArray(arr)}] -> {str}");
}

int[] array = new int[20];
WriteArray(array, 1, 20);

int number = ReadNumber();

if (FindNumber(array, number))
    PrintResult(number, array, "да");
else
    PrintResult(number, array, "нет");