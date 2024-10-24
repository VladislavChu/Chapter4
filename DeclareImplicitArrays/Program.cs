using System;



DeclareImplicitArrays();


static void DeclareImplicitArrays()
{
    Console.WriteLine("=> Implicit Array Initialization.");

    var a = new[] { 1, 10, 100, 1000 };
    Console.WriteLine($"a is a: {a}");

    var b = new[] { 1, 1.5, 2, 2.5 };
    Console.WriteLine($"b is a: {b.ToString()}");

    var c = new[] { "hello", null, "world" };
    Console.WriteLine($"c is a: {c.ToString()}");
    Console.WriteLine();
}
