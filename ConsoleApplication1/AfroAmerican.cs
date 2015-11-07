using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AfroAmerican:Human
    {
        public AfroAmerican(string name)
        {
            this.name = name;
        }
        public override string SayHello()
        {
            return "Yo, " + name;
        }
    }
}
