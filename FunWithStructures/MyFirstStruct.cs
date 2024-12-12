using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    ref struct DisposableRefSctruct
    {
        public int X;
        public readonly int Y;
        //public readonly string Name;
        public readonly void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }


        public DisposableRefSctruct(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
            Console.WriteLine("Created!");
        }

        /*
        public void Increment()
        {
            X++;
            Y++;
        }

        public void Decrement()
        {
            X--;
            Y--;
        }
        */

        public void Dispose()
        {

            Console.WriteLine("Disposed!");
        }
    }


}
