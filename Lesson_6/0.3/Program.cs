string BinaryNumber(int num)
{
    string number = string.Empty;

    for (; num != 0; num /= 2)
    {
        number = num % 2 + number;
    }
    return number;
} 

Console.WriteLine(BinaryNumber(4));


