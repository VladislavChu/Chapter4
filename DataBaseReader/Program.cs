using System;
using DataBaseReader;
using static DataBaseReader.DBReader;



Console.WriteLine("***** Fun with Nullable Value Types *****\n");

DBReader dr = new DBReader();

int? i = dr.GetIntFromDatabase();
if (i.HasValue)
{
    Console.WriteLine($"Value of 'i' is: {i.Value}");
}
else
{
    Console.WriteLine("Value of 'i' is undefined");
}

bool? b = dr.GetBooleanFromDatabase();
if (b != null)
{
    Console.WriteLine($"Value of 'b' is: {b.Value}");
}
else
{
    Console.WriteLine("Value of 'b' is undefined");
}

Console.ReadLine();



