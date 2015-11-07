using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Kub:Kvadrat
    {
        public Kub(int x) : base(x) { }
        public override int GetPerimeter()
        {
            return 12 * X;
        }
    }
}
