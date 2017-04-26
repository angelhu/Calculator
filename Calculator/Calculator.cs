using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static int Add(int x,int y)
        {
            if (x < 0)
            {
                throw new ArgumentException($"The value of x ({x}) is less than 0.");
            }
            else if (y < 0)
            {
                throw new ArgumentException($"The value of y ({y}) is less than 0.");
            }
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Division(int x, int y)
        {
            return x / y;
        }
    }
}
