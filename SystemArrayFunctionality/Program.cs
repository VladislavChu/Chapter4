using System;


SystemArrayFunctionality();
IndexAndRangesFunctionality();



static void SystemArrayFunctionality()
{
    Console.WriteLine("=> Working with System.Array");
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy"};

    Console.WriteLine("-> Here is the array: ");

    for (int i = 0; i < gothicBands.Length; i++)
    {
        Console.WriteLine(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");

    Array.Reverse(gothicBands);

    Console.WriteLine("-> The reversed array: ");

    for (int i = 0; i < gothicBands.Length; i++)
    {
        Console.WriteLine(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");


    Console.WriteLine("Clear out all but one... ");

    Array.Clear(gothicBands, 1, 2);

    for (int i = 0; i < gothicBands.Length; i++)
    {
        Console.WriteLine(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");


}


static void IndexAndRangesFunctionality()
{
    Console.WriteLine("=> Working with Indices and Ranges.");
    // Initialize items at startup.
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

    // ... and print them.
    for (int i = 0; i < gothicBands.Length; i++)
    {
        Index idx = i;
        // Print a name
        Console.Write(gothicBands[idx] + ", ");
    }
    Console.WriteLine("\n");
    for (int i = 1; i <= gothicBands.Length; i++)
    {
        Index idx = ^i;
        // Print a name
        Console.Write(gothicBands[idx] + ", ");
    }
    Console.WriteLine("\n");

    foreach (var itm in gothicBands[0..2])
    {   // Print a name
        Console.Write(itm + ", ");
    }
    Console.WriteLine("\n");
    Range r = 0..2; //the end of the range is exclusive
    foreach (var itm in gothicBands[r])
    {   // Print a name
        Console.Write(itm + ", ");
    }
    Console.WriteLine("\n");
    Index idx1 = 0;
    Index idx2 = 2;
    r = idx1..idx2; //the end of the range is exclusive
    foreach (var itm in gothicBands[r])
    {   // Print a name
        Console.Write(itm + ", ");
    }
    Console.WriteLine("\n");

    Console.WriteLine($"Array length is {gothicBands[..].Length}");
    Console.WriteLine($"Array length is {gothicBands[0..3].Length}");
    Console.WriteLine($"Array length is {gothicBands[0..^0].Length}");
}
