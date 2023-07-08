void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"|{arr[i]:N2}| ");
    }
    Console.WriteLine();
}

double[] MassNums( int size, int from, int to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1) + new Random().NextDouble();
    return arr;
}

double Diff( double[] col )
{
    double max = col.Max();
    Console.WriteLine($"Max > {max:N2}");
    double min = col.Min();
    Console.WriteLine($"Min > {min:N2}");
    double result = max - min;
    return result;

}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
double res = Diff(mass);
Console.WriteLine($"{Math.Round(res,2)}");

