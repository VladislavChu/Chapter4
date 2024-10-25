using System;


ArrayOfObjects();
static void ArrayOfObjects()
{
    Console.WriteLine("=> Array of objects.");

    object[] myObjects = new object[4];
    myObjects[0] = 10;
    myObjects[1] = false;
    myObjects[2] = new DateTime(1969, 3, 24);
    myObjects[3] = "Form & Void.";

    foreach (object obj in myObjects)
    {
        Console.WriteLine($"Type: {obj.GetType()}, Value: {obj}");
    }
    Console.WriteLine();
}