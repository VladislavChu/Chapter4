using System;



AddUsingOutParam(90, 90, out int ans);
Console.WriteLine(ans);




static void AddUsingOutParam(int x, int y, out int ans)
{
    ans = x + y;
}
