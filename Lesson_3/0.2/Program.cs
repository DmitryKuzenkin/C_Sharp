void Quarters(int x)
{
    if (x > 4 || x < 1 )
        Console.WriteLine("Такой четверти нет");
    else if (x == 1)
        Console.WriteLine("x > 0 y > 0");
    else if (x == 2)
        Console.WriteLine("x < 0 y > 0");
    else if (x == 3)
        Console.WriteLine("x < 0 y < 0");
    else if (x == 4)
        Console.WriteLine("x > 0  y < 0");
}
int num1 = int.Parse(Console.ReadLine()!);
Quarters(num1);