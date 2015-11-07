using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Circle
    {
        private int x;
        private int y;
        private double R;
        public  Circle(){}       
        public  Circle(int x, int y, double R)
        {
            this.x = x;
            this.y = y;
            this.R = R;
        }
        public double DlinnaOkr()
        {
            return 2 * Math.PI * R;
        }
        public double DlinnaOkr(double R)
        {
            return 2 * Math.PI * R;
        }
        public Circle ReturnObject()
        {
            Circle NewCircle = new Circle(x, y, R);
            return NewCircle;
        }
        public Circle ReturnObject(int x, int y, double R)
        {
            Circle NewCircle = new Circle(x, y, R);
            return NewCircle;
        }
        public bool CathPoint(int x, int y)
        {
            if (this.x + this.R >= x & this.y + this.R >= y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.x + " " + this.y + " " + this.R;
        }
    }
}
