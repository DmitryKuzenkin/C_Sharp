void Num2 (int num)
{
   
    if ( num >= 100 )
    {
        while (num / 10 > 100 )
        {
            num = num / 10;
        }
        num = num % 10;
        Console.WriteLine ("Третья цифра числа: " + num);
    }
    else 
    {
        Console.WriteLine ("Третьей цифры нет");
    }
}
Console.WriteLine("Insert your number")
int NumA = int.Parse(Console.ReadLine());
Num2(NumA);
