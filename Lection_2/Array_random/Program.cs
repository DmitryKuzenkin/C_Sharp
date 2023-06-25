using System.Linq;

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
       collection[index] = new Random().Next(1, 100);
        index++;
    }  
}
void printArray(int[] col)
{
 int count = col.Length;
 int position = 0;
 while (position < count )
 {
    Console.Write(col[position]+",");
    position++;

 }
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count )
    {
        if (collection [index] == find)
        {
             position = index;
             break;
        }
        index++;
    }
    return position;
}

int[] array = new int[100];
FillArray(array);
printArray(array);
int pos = indexOf(array, 11);


Console.WriteLine();

Console.WriteLine ("позиция " + pos);

double result = array.Average();

Console.WriteLine("Среднее " + result);