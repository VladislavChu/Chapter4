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
