
    bool Palindrome(int num)
    {
        int n1 = num; 
        int n2 = 0;

    while (n1 != 0 )
    {
        int n3 = n1 % 10 ; // тут запоминаем остаток от деления
        n2 = n2 * 10 + n3; // тут разворачиваем число 
        n1 = n1 / 10; // тут отрезаем от введенного числа последнюю цифру
    }
        return (num == n2);

    }
Console.WriteLine("Напишите Ваше число");
bool result = Palindrome(int.Parse(Console.ReadLine()!));
Console.WriteLine("Число палиндром ?: " + result);

