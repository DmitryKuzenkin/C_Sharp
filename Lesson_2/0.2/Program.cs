 /*123 % 10 -> 3
 123 % 100 -> 23

123 / 10 -> 12
123 / 100 -> 1*/

int Max(int num)
{
    if (num/10 > num % 10 )
    return num/10;

    return num % 10;
    
}
int RNum = new Random().Next (10,100);
Console.WriteLine("" + RNum);
int result = Max(RNum);
Console.WriteLine("" + result);


