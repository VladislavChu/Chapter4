using System;
using DataBaseReader;
using static DataBaseReader.DBReader;







Console.WriteLine("***** Fun with Nullable Value Types *****\n");
TesterMethod(["dwad", " "]);
Console.ReadLine();

DBReader dr = new DBReader();

//операция объединения с null
int myData = dr.GetIntFromDatabase() ?? 100;
Console.WriteLine($"Value of myData is: {myData}");
Console.ReadLine();

//операция присваивания с объединением с null
int? nullableInt = null;
nullableInt ??= 12;
nullableInt ??= 14;
Console.WriteLine(nullableInt);
Console.ReadLine();

//null- условная операция
/* 
 * static void TesterMethod(string[] args)
{
    if (args != null)
    {
        Console.WriteLine($"You sent me {args.Length} arguments.");
    }
}
*/
static void TesterMethod(string[] args)
{
    Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");
}



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



