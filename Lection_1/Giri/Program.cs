﻿int a = new Random().Next(1,150);
int b = new Random().Next(1,150);
int c = new Random().Next(1,150);
int d = new Random().Next(1,150);
int e = new Random().Next(1,150);

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine (max);

