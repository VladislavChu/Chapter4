using System;


string? nullableString = null;
TestClass? myNullableTestClass = null;
TestClass myNonNullableClass = myNullableTestClass;
#nullable disable
TestClass anotherNullableClass = null;
TestClass? badDefinition = null;
string? anotherNullableString = null;
#nullable restore

Console.WriteLine("hello");


public class TestClass
{
    public string Name { get; set; }
    public int Age { get; set; }
}


