


using static Library.Library;

int[,] MultiplicationMatrix(int[,] matr1, int[,] matr2)
{

    //      p
    //Cij = E 
    //      k=1


    if (matr1.GetLength(1) != matr2.GetLength(0))
    {
        System.Console.WriteLine("Несовместимые матрицы");
        // int[,] res1 = new int[matr1.GetLength(1), matr2.GetLength(0)];
        throw new ArithmeticException();
    }
    int p = matr1.GetLength(0);     // p x n
    int q = matr2.GetLength(1);     // n x q
    int n = matr1.GetLength(1);     // p x q

    int[,] res = new int[p, q];

    for (int i = 0; i < p; i++)
    {
        for (int j = 0; j < q; j++)
        {
            for (int k = 0; k < n; k++)
            {
                res[i, j] = res[i, j] + (matr1[i, k] * matr2[k, j]);
            }
        }
    }

    return res;
}

// int[,] matrix1 = {
//     {2, 4, 6,},
//     {3, 6, 8,},
//     {4, 8, 5,},
//     {6, 4, 2,}
//                 };
// int[,] matrix2 = {
//     {4, 5},
//     {5, 8},
//     {2, 3}
// };

while (true)
{
    try
    {
        int[,] matrix1 = new int[ReadNumber("Введите размер первой матрицы"), ReadNumber()];
        int[,] matrix2 = new int[ReadNumber("Введите размер второй матрицы"), ReadNumber()];
        matrix1 = FillMatrix(matrix1, 1, 10);
        PrintMatrix(matrix1);
        System.Console.WriteLine();

        matrix2 = FillMatrix(matrix2, 1, 10);
        PrintMatrix(matrix2);
        System.Console.WriteLine();

        PrintMatrix(MultiplicationMatrix(matrix1, matrix2));
        break;
    }
    catch (ArithmeticException)
    {
        System.Console.WriteLine("Давайте попробуем ещё раз");
    }
}
