void Num2 (int num)
{
    if (10 <= num && num < 1000)
    {
        num = (num / 10) % 10;
        Console.WriteLine ("2 цифра числа: " + num);
    }
    else 
    {
        Console.WriteLine ("Число не трехзначное");
    }
}
int NumA = int.Parse(Console.ReadLine());
Num2(NumA);