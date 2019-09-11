using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill113
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = new Class1();
            int x = 5;
            int y = 10;
            j.Meth3(x,y);
            j.Meth3(x: 5, y: 10);
        }
    }
}
