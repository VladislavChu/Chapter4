using System;


int x = 10;
int y = 20;

Console.WriteLine($"before call: x = {x}, y = {y}");
Console.WriteLine($"answer is: {Add(x, y)}");
Console.WriteLine($"after call: x = {x}, y = {y}");





static int Add(int x, int y)
{
    int ans = x + y;

    x = 10000;
    y = 88888;

    return ans;
}