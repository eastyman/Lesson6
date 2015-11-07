using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rectangle
    {
        private int xLeft;
        private int yLeft;
        private int xRight;
        private int yRight;
        public Rectangle(int xLeft, int yLeft, int xRight, int yRight)
        {
            this.xLeft = xLeft;
            this.yLeft = yLeft;
            this.xRight = xRight;
            this.yRight = yRight;
        }
        public override string ToString()
        {

            return "Координаты Вася левого угла: " + xLeft + ", " + yLeft + " координаты Вася правого угла: " + xRight + ", " + yRight;
        }
        public override int GetHashCode()
        {
            return xLeft * yLeft * xRight * yRight;
            
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Rectangle operand = (Rectangle)obj;
                return(this.xLeft==operand.xLeft &
                       this.xRight==operand.xRight &
                       this.yLeft==operand.yLeft &
                       this.yRight==operand.yRight);
            }
        }
    }
}
