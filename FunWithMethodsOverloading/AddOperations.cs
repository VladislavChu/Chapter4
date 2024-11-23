﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethodsOverloading
{
    public static class AddOperations
    {
        public static int Add(int x, int y)
            {
            return x + y; 
            }

        public static double Add(double x, double y)
            { 
            return x + y; 
            }

        public static long Add(long x, long y)
            {
            return x + y;
            }

        public static int Add(int x, int y, int z = 0)
        {
            return x + (y * z);
        }
    }
}
