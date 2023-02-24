// Задача 2: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

using static Task_2.Library;

int[] ChangeElements(int[] arr)
{
    int[] newArr = new int[arr.Length];
    
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i] * (-1);
    }
    return newArr;
}

int[] array = new int[10];
int[] newArray = new int[10];

WriteArray(array, -100, 100);


newArray = ChangeElements(array);
System.Console.WriteLine($"[ {PrintArray(array)}] -> [ {PrintArray(newArray)}]");