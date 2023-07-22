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
int[,] MassNums(int from, int to, int col, int rows)
{
    int[,] arr = new int[col,rows];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(from, to + 1);
        }
    }
    return arr;
}

void AverageCol(int[,] arr)
{
    int col = arr.GetLength(0); 
    int row = arr.GetLength(1);
    double average = 0;
    double summ = 0;

    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            summ +=arr[j,i];
        }
        average = Math.Round(summ/row,2);
        Console.WriteLine($"среднее арифметическое в {i+1} столбце {summ} / {row} = {average}");
        summ = 0;
        average = 0;
    }
}

Console.Write($"col->\t");
int col = int.Parse(Console.ReadLine()!);
Console.Write($"rows->\t");
int rows = int.Parse(Console.ReadLine()!);
Console.Write($"start->\t");
int start = int.Parse(Console.ReadLine()!);
Console.Write($"stop->\t");
int stop = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int [,] mass = MassNums(start, stop,col,rows);
PrintArray (mass);
Console.WriteLine();
AverageCol(mass);
