int a = int.Parse(Console.ReadLine()!);
int result = 0;
int temp = a;
for (int i = 0; i < a.ToString("").Length; i++)
{
    result = result + temp % 10;
    temp = temp / 10;
}
Console.WriteLine(result);



