void EvenNum(int M, int N)
{
    if (N < M) return;
    EvenNum(M, N - 1);
    if (N % 2 == 0)
    Console.Write($"{N}, ");
}

EvenNum(4, 8);