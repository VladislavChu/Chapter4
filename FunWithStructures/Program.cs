using System;
using FunWithStructures;
using static FunWithStructures.Point;



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** A First Look at Structures *****\n");

        Point myPoint;

        myPoint.X = 349;
        myPoint.Y = 76;
        myPoint.Display();

        myPoint.Decrement();
        myPoint.Display();
       

        Point p1 = new Point();
        //p1.X = 10;
        p1.Display();
    }
}