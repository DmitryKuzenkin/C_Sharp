void Method1()
{
    Console.WriteLine("Author Dimon");

}
Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);

}

Method2(msg:"Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg:"text", count: 4);

string Method4 (int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    
    }
     return result;
}
string res = Method4(10,"zvo");
Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}



