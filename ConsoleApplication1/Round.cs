using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Round:Figure
    {
        private int r; // радиус круга
        public Round(int x, int y, int r):base (x, y)
        {
            this.r = r;
        }
        public void Draw()
        {
            Console.WriteLine(this.X +" "+ Y +" "+ r);
        }
    }
}
