using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class RefAndOutDemo
    {
        static int a1 = 100;
        public static void Main(string[] values)
        {
            int b = 12;
            Add(out b, b);
            Console.WriteLine(b);

            string s = "qwer";
            SetValue(ref s);
            Console.WriteLine(s);

            Console.Read();
        }

        static void SetValue(ref string str)
        {
            str = "asdf" + str;
        }

        public static void Add(out int a, int b)
        {
            a = a1 + b;
        }
    }
}
