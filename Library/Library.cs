namespace Library;
public class Library
{
    public static void Swap(int[] arr, int a, int b)  // Меняет местами элеминты массива
    {
        int temp;
        temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    public static String PrintArray(int[] arr) //Печатает массив
    {
        string output = String.Empty;
        for (int i = 0; i < arr.Length; i++)
        {
            output += arr[i] + " ";
        }
        return output;
    }

    public static String PrintArray(double[] arr) //Печатает массив
    {
        string output = String.Empty;
        for (int i = 0; i < arr.Length; i++)
        {
            output += (Math.Round(arr[i], 2)) + " ";
        }
        return output;
    }

    public static void WriteArray(int[] arr, int a, int b) // Заполняет массив случайными числами в промежутке [a, b)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(a, b);
        }
    }

    public static void WriteArray(int[] arr) // Заполняет массив случайными числами в промежутке [1, 1000)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(0, 1000);
        }
    }

    public static void WriteArray(int[] arr, int order) // Заполняет массив числами от 1 до n, где n - длина массива
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
    }

    public static int ReadNumber()  //Чтение числа с клавиатуры
    {
        int num;
        while (true)
        {
            try
            {

                System.Console.WriteLine("Введите число");
                num = int.Parse(Console.ReadLine());
                return num;
            }
            catch
            {
                System.Console.WriteLine("Это не число!!! \n");
            }
        }
    }

    public static int ReadNumber(string text)  //Чтение числа с клавиатуры c входящим сообщением
    {
        int num;
        while (true)
        {
            try
            {
                System.Console.WriteLine(text);
                System.Console.WriteLine("Введите число");
                num = int.Parse(Console.ReadLine());
                return num;
            }
            catch
            {
                System.Console.WriteLine("Это не число!!! \n");
            }
        }
    }

    public static int[,] FillMatrix(int[,] matr, int minValue, int maxValue)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(minValue, maxValue);
            }
        }
        return matr;
    }

    public static void PrintMatrix(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                System.Console.Write($"{matr[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }
}
