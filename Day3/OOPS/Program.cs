using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Shape()
        {
            Console.WriteLine("Shape Constructor");
        }
    }

    class Triangle : Shape
    {
        string kind;
        static long DateOfCreation;
        static Triangle() //static constructor called when the first object is created
        {
            DateOfCreation = DateTime.Now.Ticks;
            Console.WriteLine("Called");
        }
        public Triangle(double v1, double v2): this(v1)
        {
            Height = v2;
        }
        public Triangle(double Width)
        {
            this.Width = Width;
        }
        //private Triangle(double area) // Private constructor usefull only for singleton cases
        //{
            
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Triangle t1 = new Triangle(12.3, 34.0);
            Shape s1 = t1;
            Triangle t2 = new Triangle(5.0, 10.0);
            Console.WriteLine(t1 == s1);
            Console.Read();
        }
    }
}
