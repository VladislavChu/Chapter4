using System;
using FunWithStructures;
using static FunWithStructures.DisposableRefSctruct;



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** A First Look at Structures *****\n");


        //myPoint.X = 349;
        //myPoint.Y = 76;
        //myPoint.Display();

        //myPoint.Decrement();



        DisposableRefSctruct p1 = new DisposableRefSctruct(50, 60);
        //p1.X = 10;
        p1.Display();
        p1.Dispose();
    }
}