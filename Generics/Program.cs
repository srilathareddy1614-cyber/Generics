using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class myclass
    {
        internal void display<T>(T s)
        {
            Console.WriteLine(s);
        }
        internal void add<T>(T a,T b)
        {
            Console.WriteLine("value of a is : " + a);
            Console.WriteLine("value of b is : " + b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.display<int>(88);
            obj.display<string>("welcome");
            obj.display<double>(3.14);
            obj.display<bool>(true);
            obj.add<int>(45, 36);
            obj.add<string>("good", "morning");
            obj.add<double>(3.45, 6.37);
            obj.add<bool>(true, false);
        }
    }
}
