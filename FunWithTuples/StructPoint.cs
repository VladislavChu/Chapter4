using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    struct Point
    {
        // Поля структуры,
        public int X;
        public int Y;
        // Специальный конструктор,
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }
        public (int XPos, int YPos) Deconstruct() => (X, Y);
        public void Deconstruct(out int XPos, out int YPos) => (XPos, YPos) = (X, Y);
    }
}
