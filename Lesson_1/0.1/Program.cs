try
{
    Console.WriteLine("Введите число");
    int a = int.Parse(Console.ReadLine()!);
    a= a*a;
    Console.WriteLine("Квадрат числа = "+ a);

}

catch (System.Exception)
{
    Console.WriteLine("Неверный ввод");

}
