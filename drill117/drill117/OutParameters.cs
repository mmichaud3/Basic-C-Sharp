using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill117
{
    public class OutParamaters
    {
        public void getNums(out int x, out int y)
        {
            x = 3;
            y = 5;
        }
    }
}
