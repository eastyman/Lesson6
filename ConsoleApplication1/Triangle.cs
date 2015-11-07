using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangle:Figure
    {
        //стороны треугольника
        private int a;
        private int b;
        private int c;
        public Triangle(int x, int y, int a, int b, int c):base (x, y)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
       public void Draw()
        {
            Console.WriteLine(X + " " + Y + " " + a + " " + b + " " + c);
        }
    }
}
