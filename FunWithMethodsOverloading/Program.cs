using System;
using FunWithMethodsOverloading;
using static FunWithMethodsOverloading.AddOperations;

Console.WriteLine("***** Fun with Method Overloading *****\n");
//int
Console.WriteLine(Add(10, 10));
//int with optional parameter
Console.WriteLine(Add(10, 5, 3));
//long
Console.WriteLine(Add(900_000_000_000, 900_000_000_000));
//double
Console.WriteLine(Add(4.3, 4.4));
