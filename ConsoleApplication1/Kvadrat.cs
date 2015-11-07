using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Kvadrat
    {
        public int X { get; set; }
        public Kvadrat(int x)
        {
            X = x;
        }
        public virtual int GetPerimeter()
        {
            return X * 4;
        }
    }
}
