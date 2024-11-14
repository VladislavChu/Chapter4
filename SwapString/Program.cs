using System;


static void SwapStrings(ref string s1, ref string s2)
{
    string tempStr = s1;
    s1 = s2;
    s2 = tempStr;
}


Console.WriteLine("*****Fun with methods*****");
string str1 = "Flip";
string str2 = "Flop";
Console.WriteLine($"Before: {str1}, {str2}");

SwapStrings(ref str1, ref str2);

Console.WriteLine($"After: {str1}, {str2}");
