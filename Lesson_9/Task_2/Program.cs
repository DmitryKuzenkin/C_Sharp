Console.Write("M->");
int M = int.Parse(Console.ReadLine()!);
Console.Write("N->");
int N = int.Parse(Console.ReadLine()!);
int summ(int M, int N)
{
if (M==N)
return N;
else return M + summ(M+ 1, N);
}
Console.Write($"Сумма чисел от {M} до {N} равна {summ(M,N)}");