int Summ(int a)
{ 
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}
int num = Summ(int.Parse(Console.ReadLine()!));
Console.WriteLine($"->{num}");

