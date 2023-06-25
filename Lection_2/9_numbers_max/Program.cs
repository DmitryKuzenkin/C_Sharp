/*
int max = a1;
if (b1 > max)
   max = b1;
if (c1 > max)
   max = c1;
if (a2 > max)
   max = a2;
if (b2 > max)
   max = b2;
if (c2 > max)
   max = c2;
if (a3 > max)
   max = a3;
if (b3 > max)
   max = b3;
if (c3 > max)
    max = c3;
    */

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result)
        result = arg2;
    if (arg3 > result)
        result = arg3;
    return result;
}
/*int a1 = 54;
int b1 = 45;
int c1 = 73;
int a2 = 22;
int b2 = 5;
int c2 = 668;
int a3 = 54;
int b3 = 6756756;
int c3 = 57;*/

int[] array = { 1, 2, 67, 54, 6, 7, 8, 456, 41436, 346, 35 };

/*int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3); */

int max = Max
(Max(a1,b1,c1),
Max(a2,b2,c2),
Max(a3,b3,c3));

Console.Write(max);



