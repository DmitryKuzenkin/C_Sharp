//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine ("Insert 1st number");
double a = double.Parse(Console.ReadLine()!);
Console.WriteLine ("Insert 2nd number");
double b = double.Parse(Console.ReadLine()!);
Console.WriteLine ("Insert 3rd number");
double c = double.Parse(Console.ReadLine()!);
double max = a;
if (max < b)
    max = b;
if (max < c)
    max = c;
Console.Write("max number is "+ max);






