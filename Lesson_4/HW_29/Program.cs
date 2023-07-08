void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
       collection[i] = new Random().Next(0,100);
    }  
}
void printArray(int[] col)
{
 for (int i = 0; i < col.Length - 1; i++)
   {
      Console.Write(col[i]+",");
   }
}
int[] array = new int[8];
FillArray(array);
printArray(array);