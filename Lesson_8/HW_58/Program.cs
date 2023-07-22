void PrintArray(int[,] arr)


{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {
                 Console.Write($"{arr[i,j]}\t");
            }
        Console.WriteLine();
    }
}
int[,] MassNums(int from, int to, int col, int row)
{
    int[,] arr = new int[col,row];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(from, to + 1);
        }
    }
    return arr;
}
void MatrixProd(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        Console.WriteLine("Результат");
        PrintArray(result);
    }
    else
    {
    Console.WriteLine();
    Console.WriteLine("Матрицы не перемножаются");
    }
}


Console.Write($"col->\t");
int col = int.Parse(Console.ReadLine()!);
Console.Write($"row->\t");
int row = int.Parse(Console.ReadLine()!);
Console.Write($"start->\t");
int start = int.Parse(Console.ReadLine()!);
Console.Write($"stop->\t");
int stop = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int [,] mass = MassNums(start, stop, col, row);

Console.Write($"col2->\t");
col = int.Parse(Console.ReadLine()!);
Console.Write($"row2->\t");
row = int.Parse(Console.ReadLine()!);
Console.Write($"start2->\t");
start = int.Parse(Console.ReadLine()!);
Console.Write($"stop2->\t");
stop = int.Parse(Console.ReadLine()!);

int [,] mass1 = MassNums(start, stop, col, row);
Console.WriteLine("1я матрица");
Console.WriteLine();
PrintArray(mass);
Console.WriteLine();
Console.WriteLine("2я матрица");
Console.WriteLine();
PrintArray(mass1);
MatrixProd(mass,mass1);





