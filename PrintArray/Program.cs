using System;

PassAndReceiveArrays();


static void PrintArray(int[] myInts)
{
    for (int i = 0; i < myInts.Length; i++)
    {
        Console.WriteLine($"Item {i} is {myInts[i]}");
    }
}

static string[] GetStringArray()
{
    string[] theStrings = {"Hello", "from", "GetStringArray"};
    return theStrings;
}


static void PassAndReceiveArrays()
{
    Console.WriteLine("=> Arrays as params and return values.");

    int[] ages = { 20, 22, 23, 0 };
    PrintArray(ages);

    string[] strs = GetStringArray();
    foreach(string s in strs) 
        Console.WriteLine(s);
    Console.WriteLine();
}