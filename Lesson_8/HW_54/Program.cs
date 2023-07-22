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


void selectionSort(int[,] array)
{
    int col = array.GetLength(0);
    int row = array.GetLength(1);

    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row - 1 ; j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < row; k++)
            {
                if (array[i, k] > array[i, maxPosition]) 
                {
                    maxPosition = k;
                }
            }
            int temporary = array[i,j];
            array[i,j] = array[i,maxPosition];
            array[i,maxPosition] = temporary;

        }
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
selectionSort(mass);
Console.WriteLine();
PrintArray(mass);