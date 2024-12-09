using System;
using FunWithStructures;
using static FunWithStructures.ReadOnlyPoint;



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** A First Look at Structures *****\n");

        ReadOnlyPoint myPoint = new ReadOnlyPoint();

        myPoint.Display();

        //myPoint.X = 349;
        //myPoint.Y = 76;
        //myPoint.Display();

        //myPoint.Decrement();



        ReadOnlyPoint p1 = new ReadOnlyPoint(90, 60, "Sophi");
        //p1.X = 10;
        p1.Display();
    }
}