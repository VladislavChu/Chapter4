using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    struct ReadOnlyPoint
    {
        public int X;
        public readonly int Y;
        public readonly string Name;



        public ReadOnlyPoint(int xPos, int yPos, string name)
        {
            X = xPos;
            Y = yPos;
            Name = name;
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

        public readonly void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
        }
    }
}
