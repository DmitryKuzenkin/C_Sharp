
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int a = int.Parse(Console.ReadLine()!);
int count = 2;

Console.WriteLine("Insert the number");

while (count <=a )
{
    Console.Write(count+",");
    count = count + 2;  
}





