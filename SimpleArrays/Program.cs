﻿using System;


Console.WriteLine("*****Fun with arrays*****");
SimpleArrays();

Console.ReadLine();

static void SimpleArrays()
{
    Console.WriteLine("=> Simple Array Creation.");

    int[] myInts = new int[3];
    myInts[0] = 100;
    myInts[1] = 200;
    myInts[2] = 300;

    foreach (int i in myInts)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();

    string[] booksOnDotNet = new string[100];
    Console.WriteLine();
}

