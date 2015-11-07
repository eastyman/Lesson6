using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ukrainian:Human
    {
        public Ukrainian(string name)
        {
            this.name = name;
        }
        public override string SayHello()
        {
            return "Привіт, " + name;
        }
    }
}
