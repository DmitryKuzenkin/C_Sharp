void PrintArray(double[,] arr)


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

double[,] MassNums(int col, int rows, int from, int to)
{
    double[,] arr = new double[col,rows];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(new Random().NextDouble() * (to - from)+ from , 2);
        }
    }
    return arr;
}
Console.Write($"col->\t");
int col = int.Parse(Console.ReadLine()!);
Console.Write($"rows->\t");
int rows = int.Parse(Console.ReadLine()!);
Console.Write($"from->\t");
int from = int.Parse(Console.ReadLine()!);
Console.Write($"to->\t");
int to = int.Parse(Console.ReadLine()!);

double [,] mass = MassNums(col, rows, from, to);
PrintArray(mass);
