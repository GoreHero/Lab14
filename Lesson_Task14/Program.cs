using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Triangle triangle = new Triangle(1,2,3);
            //RectangularTriangle  rectangularTriangle = new RectangularTriangle(4,5);
            //Triangle triangle = rectangularTriangle;//апкастинг
            //RectangularTriangle rectangularTriangle1 = (RectangularTriangle)triangle;//даункастинг//явное преобразование
            RegularTriangle regularTriangle = new RegularTriangle();
            Triangle triangle = regularTriangle;
            if (triangle is RectangularTriangle)//безопасно
            {
                RectangularTriangle rectangularTriangle = (RectangularTriangle)triangle;
            }
            //RectangularTriangle rectangularTriangle = triangle as RectangularTriangle;//неявное преобразование
            Console.ReadKey();
        }
    }
    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle()
        { }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public virtual double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        //public virtual double GetArea() //Переопределение метода
        //{
        //    double p = (A + B + C) / 2;
        //    return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        //}

    }
    class RectangularTriangle : Triangle
    {
        public RectangularTriangle(double a, double b)
        {
            A = a;
            B = b;
            C = Math.Sqrt(a * a + b * b);
        }
        //    :base (a,b,Math.Sqrt(a*a+b*b))
        //{

        //}
        public new double GetArea()
        {
            return A*B/2;
        }
        //public override double GetArea() //Переопределение метода
        //{
        //    return A * B / 2;
        //}
    }
    class RegularTriangle : Triangle
    {

    }
}