using System;


static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string.";
    c = true;
}


Console.WriteLine("***** Fun with methods *****");
FillTheseValues(out int i, out _, out _);
Console.WriteLine("Int is: {0}", i); // Вывод целочисленного значения
//Console.WriteLine("String is: {0}", str); // Вывод строкового значения
//Console.WriteLine("Boolean is: {0}", b); // Вывод булевского значения
Console.ReadLine();
