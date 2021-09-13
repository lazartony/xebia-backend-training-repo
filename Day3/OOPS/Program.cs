using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Shape
    {
        double Width;
        double Height;
    }

    class Triangle : Shape
    {
        string kind;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Triangle t2 = t1;
            Console.WriteLine(t1 == t2);
            Console.Read();
        }
    }
}
