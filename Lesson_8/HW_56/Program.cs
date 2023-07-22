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
int[,] MassNums(int from, int to, int side)
{
    int[,] arr = new int[side,side];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(from, to + 1);
        }
    }
    return arr;
}

void minRow(int[,] arr)
{   
    int minSumm = 0;
    int summ1Row = 0;
    int summ2Row = 0;
    for (int k = 0; k < arr.GetLength(1); k++)
        {   
            summ1Row += arr[0,k];
        }

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ2Row += arr[i, j];
          
        } 
        if (summ2Row < summ1Row)
            {
                minSumm = i;
                summ1Row = summ2Row;
            }
            summ2Row = 0;
    }
   Console.WriteLine($"Минимальная строчка {minSumm+1}");
}




Console.Write($"side->\t");
int side = int.Parse(Console.ReadLine()!);
Console.Write($"start->\t");
int start = int.Parse(Console.ReadLine()!);
Console.Write($"stop->\t");
int stop = int.Parse(Console.ReadLine()!);

Console.WriteLine();
int [,] mass = MassNums(start, stop, side);
PrintArray (mass);
minRow(mass);







