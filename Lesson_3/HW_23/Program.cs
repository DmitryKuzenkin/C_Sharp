Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int count = 1;
if (a == 0 )
{
 Console.WriteLine("1");
 Console.WriteLine("0");
}
else {
while (Math.Abs(count) <= Math.Abs(a) )
        {
            Console.WriteLine(Math.Pow(count, 3));
             count--;
        }
}

