using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class newclass<k,l,m>
    {
        k a;
        l b;
        m c;
        internal newclass(k a, l b, m c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void display()
        {
            Console.WriteLine("employee id : " + a);
            Console.WriteLine("employee name : " + b);
            Console.WriteLine("employee salary : " + c);
            Console.WriteLine("`````````````````````````````````````");
        }
    }
    internal class GenericClass2
    {
        static void Main()
        {
            newclass<int, string, double> m =new newclass<int, string, double>(102, "ravi", 55000.55);
            m.display();
            newclass<int, string, double> n = new newclass<int, string, double>(105, "john", 46000.00);
            n.display();
        }
    }
}
