/*string[,] table = new string[2,5];
table [1,2] = "Слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int col = 0; col < 5; col++)
    {
        Console.WriteLine($"-{table[rows,col]}-");
    }
}

Console.WriteLine();*/

void PrintArray(int[,] arr)


{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {
                 Console.Write($"|{arr[i,j]}|");
            }
    Console.WriteLine();
    }
}
int[,] MassNums(int from, int to)
{
    int col = new Random().Next(1,11);
    int rows = new Random().Next(1,11);
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
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = new int[10,10];
PrintArray (mass);
Console.WriteLine();
mass = MassNums(start, stop);
PrintArray (mass);
