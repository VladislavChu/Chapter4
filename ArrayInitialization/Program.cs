using System;


ArrayInitialization();


static void ArrayInitialization()
{
    Console.WriteLine("=> Array Initialization.");


    string[] stringArray = new string[] { "one", "two", "three" };
    Console.WriteLine($"stringArray has {stringArray.Length} elements.");

    bool[] boolArray = { false, false, true };
    Console.WriteLine($"boolArray has {boolArray.Length} elements.");

    int[] intArray = new int[4] { 1, 2, 3, 0 };
    Console.WriteLine($"intArray has {intArray.Length} elements.");
    Console.WriteLine();
}
