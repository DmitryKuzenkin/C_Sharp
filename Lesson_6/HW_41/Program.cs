void Print(int[] arr)
{
    int size = arr.Length;
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}\t ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[] arrRead()
{
   Console.Write("Введите количество вводимых цифр:\t");
   int n = int.Parse(Console.ReadLine()!);
   int [] arr = new int[n];
   for (int i = 0; i < arr.Length; i++)
   {
        Console.Write($"Введите {i+1} элемент массива:\t");
        arr[i] = int.Parse(Console.ReadLine()!);
   }
  
    return arr;


}

int CountZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++ ;
        }
    }
    return count;
}
int[] myArray = arrRead();
Print(myArray);
int result = CountZero(myArray);
Console.WriteLine($"Количество чисел больше 0 = {result}");
