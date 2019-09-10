using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Numbers
    {
        public int Factorial(int n)
        {
            int f = 1;

            for (int i = 1; i<= n; i++)
            {
                f = f * i;
            }
            return f;
        }
        public int Sum(int x, int y)
        {
            int a = x;
            int b = y;

            int result = a + b;
            return result;
        }
        public int Product(int x, int y)
        {
            int d = x;
            int e = y;

            int result = d * e;
            return result;
        }

    }
}
