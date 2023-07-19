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

string FindElement(double[,]arr , int x, int y )
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1); 

    if (x > row|| x<= 0 || y > col || y <= 0)
        return $"[{x},{y}] - Неверные координаты";
    return $"[{x},{y}] -> {arr[x-1,y-1]} - Ваше число";
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
Console.Write($"x->\t");
int x = int.Parse(Console.ReadLine()!);
Console.Write($"y->\t");
int y = int.Parse(Console.ReadLine()!);
string result = FindElement(mass,x,y);
Console.Write(result);

