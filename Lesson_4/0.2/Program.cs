int Count(int a)
{
    int count = 0;
    for (int i = 1; a != 0; i++)
    {
        count = i;
        a /= 10;
    }
    return count;
}
int result = Count(int.Parse(Console.ReadLine()!));
Console.WriteLine(result);
