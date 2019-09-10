using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill114
{
    public class Class2
    {
        public int Meth1(int x, int y)
        {
            int result = x + y;
            return result;
        }

        public decimal Meth1(decimal a, decimal b)
        {
            decimal result = (a * b);
            decimal floor = Math.Floor(result);
            return floor;
        }
        public int Meth1(string g, int d)
        {

            int h = Convert.ToInt32(g);
            int f = d / h;
            return f;
        }
    }
}
