// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
using static Library.Library;


void PrintPascalTreangle(int[][] pas)
{
    string space = String.Empty;
    for (int i = 0; i < pas.Length; i++)
    {
        space += " ";
    }
    for (int i = 0; i < pas.Length; i++)
    {
        System.Console.Write(space);
        for (int j = 0; j < pas[i].Length; j++)
        {
            System.Console.Write($"{pas[i][j]}  ");
        }
        space = space.Remove(pas.Length - i - 1);
        System.Console.WriteLine();
    }
}

int[][] CreatePascalTreangle(int n)
{
    int[][] pascal = new int[n][];

    for (int i = 0; i < n; i++)
    {
        pascal[i] = new int[i + 1];
    }
    return pascal;
}

int[][] FillPascalTreangle(int[][] pascal)
{
    int n = pascal.Length;
    for (int i = 0; i < n; i++)
    {
        int k = pascal[i].Length;
        for (int j = 0; j < k; j++)
        {
            if (j == 0 || j == k - 1)
            {
                pascal[i][j] = 1;
            }
            else
            {
                pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
            }
        }
    }
    return pascal;
}


int n = ReadNumber();
int[][] pascal = CreatePascalTreangle(n);

pascal = FillPascalTreangle(pascal);


PrintPascalTreangle(pascal);