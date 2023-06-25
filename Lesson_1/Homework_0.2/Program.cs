//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

double a = double.Parse(Console.ReadLine()!);
double b = double.Parse(Console.ReadLine()!);

if (a>b)
 Console.Write (a+">"+b);
else if (a==b)
Console.Write (a+"="+b);
else Console.Write (a+"<"+b);
