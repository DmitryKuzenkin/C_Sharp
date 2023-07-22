
void EvenNum(int M, int N)
{
    if (M > 0)
    {
        Console.Write($"{M},");
        M = M + 2;
        if (M <= N)
            EvenNum (M, N); 
    } 
    else Console.WriteLine("Промежуток неверный");
}

Console.Write($"M->\t");
int M = int.Parse(Console.ReadLine()!);
Console.Write($"N->\t");
int N = int.Parse(Console.ReadLine()!);
EvenNum(M, N);
