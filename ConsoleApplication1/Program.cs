using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Circle normalCircle = new Circle(5, 6, 10);
            //Circle emrtyCircle = new Circle();

            //Console.WriteLine(normalCircle.DlinnaOkr());
            //Console.WriteLine(normalCircle.DlinnaOkr(5.6));
            //Console.WriteLine(emrtyCircle.DlinnaOkr());
            //Console.WriteLine(emrtyCircle.DlinnaOkr(100));
            //Circle copyCircle = normalCircle.ReturnObject();
            //Console.WriteLine(copyCircle.DlinnaOkr());
            //Circle secondCopyCircle = normalCircle.ReturnObject(100,200,500);
            //Console.WriteLine(secondCopyCircle.DlinnaOkr());
            //Console.WriteLine(secondCopyCircle.CathPoint(7, 8));
            //Console.WriteLine(secondCopyCircle.CathPoint(1000, 2000));
            //Console.WriteLine(secondCopyCircle.ToString());
            
            //Задание 2
            //Round NewRound = new Round(5, 6, 10);
            //Triangle NewTriangle = new Triangle(1,2,10,6,7);
            //NewRound.Draw();
            //NewTriangle.Draw();
           
            //Задание 3
            //Kvadrat NewKvadrat = new Kvadrat(10);
            //Console.WriteLine(NewKvadrat.GetPerimeter());
            //Kvadrat NewKube = new Kub(10);
            //Console.WriteLine(NewKube.GetPerimeter());

           // Задание 4
            //Human[] humans = new Human[2];
            //humans[0]  = new Ukrainian("Vasya");
            //humans[1]  = new AfroAmerican("Jamal");
            //foreach (Human h in humans)
            //{
            //    Console.WriteLine(h.SayHello());
            //}

            //Задание 5

            //Rectangle firstRectangle = new Rectangle(5, 10, 20, 5);
            //Console.WriteLine(firstRectangle.ToString());
            //Console.WriteLine(firstRectangle.GetHashCode());
            //Rectangle secondRectangle = new Rectangle(5, 10, 20, 5);
            //Console.WriteLine(firstRectangle.Equals(secondRectangle));
            //Rectangle thirdRectangle = new Rectangle(5, 30, 20, 5);
            //Console.WriteLine(secondRectangle.Equals(thirdRectangle));
            
            //Задание 6
            object[] arrObj = new object[6];
            arrObj[0] = 5;
            arrObj[1] = "a";
            arrObj[2] = 's';
            arrObj[3] = 4.5;
            arrObj[4] = new object();
            arrObj[5] = (long)200;

            int a1 = (int)arrObj[0];
            string a2 = (string)arrObj[1];
            char a3 = (char)arrObj[2];
            double a4 = (double)arrObj[3];
            object a5 = arrObj[4];
            byte a6 = (byte)(long)arrObj[5];

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.WriteLine(a6);

        }
    }
}
