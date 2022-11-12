using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    
    
    abstract class Figure
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract string Name { get; set; }
    }
    class Rectangle :Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width*Height;
        }

        public override double GetPerimeter()
        {
            return Width*2+Height*2;
        }
        public override string Name
        {
            get { return Name; }
            set { Name = value; }
        }
    }
}
