using System;





var values = ("a", 5, "c");

Console.WriteLine($"First item: {values.Item1}");
Console.WriteLine($"Second item: {values.Item2}");
Console.WriteLine($"Third item: {values.Item3}");

(string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");

Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");

Console.WriteLine($"First item: {valuesWithNames.Item1}");
Console.WriteLine($"Second item: {valuesWithNames.Item2}");
Console.WriteLine($"Third item: {valuesWithNames.Item3}");

Console.WriteLine("=> Nested Tuples");
var nt = (5, 4, ("a", "b"));

Console.WriteLine($"First item: {nt.Item1}");
Console.WriteLine($"Second item: {nt.Item2}");
Console.WriteLine($"Third item: {nt.Item3.Item1}");


Console.WriteLine("=> Inferred Tuple Names");
var foo = new {Prop1 = "First", Prop2 = "Second"};
var bar = (foo.Prop1, foo.Prop2);
Console.WriteLine($"{bar.Prop1}, {bar.Prop2}");


Console.WriteLine("=> Tuples Equality/Inequality");
var left = (a: 5, b: 10);
(int? a, int? b) nullableMembers = (5, 10);
Console.WriteLine(left == nullableMembers);

(long a, long b) longTuple = (5, 10);
Console.WriteLine(left == longTuple);

(long a, int b) longFirst = (5, 10);
(int a, long b) longSecond = (5, 10);
Console.WriteLine(longFirst == longSecond);

/* This method
static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string.";
    c = true;
}
* will be transform to:
*/

static (int a, string b, bool c) FillTheseValues()
{
    return (9, "Enjoy your string.", true);
}

/*
object x;
x = FillTheseValues();
Console.WriteLine(x);
*/

var samples = FillTheseValues();
Console.WriteLine($"Int is: {samples.a}");
Console.WriteLine($"String is: {samples.b}");
Console.WriteLine($"Bool is: {samples.c}");



static (string first, string middle, string last) SplitNames(string fullName)
{
    //код для расщепления имени
    return ("Philip", "F", "Japikse");
}

var (first, _, last) = SplitNames("Fhilip F Japikse");
Console.WriteLine($"{first} : {last}");

