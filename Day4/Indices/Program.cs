using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indices
{
    class Program
    {
        private String[] names = new string[10];

        public string this[int index]
        {
            get
            {
                return (index >= 0 && index <= 9) ? names[index] : "";
            }
            set
            {
                if(index>=0 && index <= 9)
                {
                    names[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;
                while(index<10)
                {
                    if(names[index]==name)
                    {
                        return index;
                    }
                }
                return -1;
            }
            set
            {
                if (value >= 0 && value <= 9)
                {
                    names[value] = name;
                }
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program[0] = "Hai";
            Console.WriteLine(program[0]);
            Console.WriteLine(program["Hai"]);
            Console.Read();
        }
    }
}
