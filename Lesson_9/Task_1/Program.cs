void EvenNum(int M, int N)
{
    if (N < M)
    return;
    if (M % 2 == 0)
    {
        Console.Write($"{M}, ");
    }
    EvenNum(M+1, N);
    
}

Console.Write("M->");
int M = int.Parse(Console.ReadLine()!);
Console.Write("N->");
int N = int.Parse(Console.ReadLine()!);

EvenNum( M, N);


