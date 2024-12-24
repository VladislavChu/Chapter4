using System;
using FunWithTuples;
using static FunWithTuples.Point;





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
Console.WriteLine($"{first} {last}");

/*
static string RockPaperScissors((string first, string second) value)
{
    return value switch
    {
        ("rock", "paper") => "Rock is covered by paper. Paper wins.",
        ("rock", "scissors") => "Rock breaks scissors. Rock wins.",
        ("paper", "rock") => "Paper covers rock. Paper wins.",
        ("paper", "scissors") => "Paper is cut by scissors. Scissors wins.",
        ("scissors", "rock") => "Scissors are broken by rock. Rock wins.",
        ("scissors", "paper") => "Scissors cuts paper. Scissors wins.",
        (_, _) => "Tie."
    };
}
*/


Point p = new Point(7, 5);
var pointValues = p.Deconstruct();
Console.WriteLine($"X is: {pointValues.XPos}");
Console.WriteLine($"Y is: {pointValues.YPos}");


static string GetQuadrant2(Point p)
{
    return p switch
    {
        (0, 0) => "Origin",
        var (x, y) when x > 0 && y > 0 => "One",
        var (x, y) when x < 0 && y > 0 => "Two",
        var (x, y) when x < 0 && y < 0 => "Three",
        var (x, y) when x > 0 && y < 0 => "Four",
        var (_, _) => "Border",
        //_ => "Unknown",
    };
}

var c = GetQuadrant2(p);
Console.WriteLine(c);