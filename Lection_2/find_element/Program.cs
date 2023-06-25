int [] array = {13,276,3,444,53,436,27,568,98,};

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (find == array[index])
    {
        Console.WriteLine(index);
        break;
    }
    index++;


}

