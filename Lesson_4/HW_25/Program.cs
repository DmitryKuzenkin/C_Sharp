Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);
int Result = 1;

for (int i = 0; i < b; i++)
{
    
    Result = Result * a;

}

Console.WriteLine(Result);

